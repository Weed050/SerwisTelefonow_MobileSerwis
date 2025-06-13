using SerwisTelefonow.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using PdfiumViewer;
using Font = iTextSharp.text.Font;
using Rectangle = iTextSharp.text.Rectangle;
using PdfDocument = PdfiumViewer.PdfDocument;
using System;
using Microsoft.EntityFrameworkCore;
using SerwisTelefonow.DBModels;
using System.Windows.Forms;
using System.Drawing;
using System.Text;

namespace SerwisTelefonow.Models
{
    public partial class PrintServisInfo : Form
    {
        private readonly AppDbContext context;
        private ServiceEntry selectedEntry;
        private PdfViewer pdfViewer;
        private SplitContainer splitContainer;

        public PrintServisInfo(AppDbContext _context)
        {
            InitializeComponent();
            context = _context;

            // ustawnienie struktury na formularzu
            InitializeComponents();

            // załadowanie danych
            LoadServiceEntries();
        }

        private void InitializeComponents()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            splitContainer = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Vertical,
                SplitterDistance = (int)(this.Width * 0.4)
            };


            // panel dla PDF Viewer
            Panel pdfPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            // utworzenie PDF Viewer
            pdfViewer = new PdfViewer
            {
                Dock = DockStyle.Fill
            };

            pdfPanel.Controls.Add(pdfViewer);

            splitContainer.Panel1.Controls.Add(pdfPanel);
            splitContainer.Panel2.Controls.Add(dataGridViewServRecords);

            this.Controls.Add(splitContainer);
        }

        // wygenerowanie kodu w którym zawarte jest id klienta i id wpisu serwisowego
        // [XXX - salt][YYY - service_entr_id][XX - salt][YYY - client_id][X - salt]
        // YYY -> np. 002 -> 2
        public static string GenerateServiceCode(int serviceEntryId, int clientId)
        {
            const int idFieldLength = 3;

            string servicePart = serviceEntryId.ToString("D" + idFieldLength);
            string clientPart = clientId.ToString("D" + idFieldLength);

            char RandomChar(Random rnd)
            {
                const string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return pool[rnd.Next(pool.Length)];
            }

            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(12);
            for (int i = 0; i < 3; i++) { sb.Append(RandomChar(rnd)); }
            sb.Append(servicePart);
            for (int i = 0; i < 2; i++) { sb.Append(RandomChar(rnd)); }
            sb.Append(clientPart);
            sb.Append(RandomChar(rnd));

            return sb.ToString();
        }

        private void LoadServiceEntries()
        {
            // wczytanie danych do tabeli
            try
            {
                var source = context.ServiceEntry
                    .Include(se => se.Client)
                    .Include(se => se.Model)
                    .OrderByDescending(se => se.Id)
                    .Select(se => new
                    {
                        se.Id, 
                        Klient = $"{se.Client.Imie} {se.Client.Nazwisko}",
                        Model = se.Model.PelnaNazwa,
                        se.IMEI,
                        se.Opis,
                        CenaWstepna = se.CenaWstepna.HasValue ? $"{se.CenaWstepna.Value.ToString("0.00")} zł" : "brak",
                        CenaKoncowa = se.CenaKoncowa.HasValue ? $"{se.CenaKoncowa.Value.ToString("0.00")} zł" : "brak"
                    })
                    .ToList();

                dataGridViewServRecords.DataSource = source;

                // automatycznie wybranie pierwszego wiersza, żeby nie było potencjalnej wartości null
                // i żeby już przy załadowaniu strony wygenerował plik .pdf
                if (dataGridViewServRecords.Rows.Count > 0)
                {
                    dataGridViewServRecords.Rows[0].Selected = true;

                    var selectedItem = dataGridViewServRecords.Rows[0].DataBoundItem;
                    var idProperty = selectedItem.GetType().GetProperty("Id");
                    if (idProperty != null)
                    {
                        var selectedId = (int)idProperty.GetValue(selectedItem);
                        LoadSelectedEntry(selectedId);
                    }
                    // pobranie id z wiersza
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd ładowania danych: {ex.Message}");
            }
        }

        private void LoadSelectedEntry(int entryId)
        {
            selectedEntry = context.ServiceEntry
                .Include(se => se.Client)
                .Include(se => se.Model)
                .FirstOrDefault(se => se.Id == entryId);

            if (selectedEntry != null)
            {
                DisplayPdf();
            }
        }

        private void dataGridViewServRecords_SelectionChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"Liczba zaznaczonych wierszy: {dataGridViewServRecords.SelectedRows.Count}");

            if (dataGridViewServRecords.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewServRecords.SelectedRows[0];
                Console.WriteLine($"Typ obiektu: {selectedRow.DataBoundItem?.GetType().Name}");

                if (selectedRow.DataBoundItem != null)
                {
                    // z BoundItem (obiekt z wszystkimi wartościami, nawet tymi po relacjach) pobiera id 
                    var idProperty = selectedRow.DataBoundItem.GetType().GetProperty("Id");
                    if (idProperty != null)
                    {
                        var selectedId = (int)idProperty.GetValue(selectedRow.DataBoundItem);
                        Console.WriteLine($"Wybrane ID: {selectedId}");
                        LoadSelectedEntry(selectedId);
                    }
                    else
                    {
                        Console.WriteLine("Nie znaleziono właściwości 'Id'");
                    }
                }
                else
                {
                    Console.WriteLine("Brak powiązanego obiektu");
                }
            }
            else
            {
                Console.WriteLine("Brak zaznaczonych wierszy");
            }
        }
        private void DisplayPdf()
        {
            try
            {
                if (selectedEntry == null)
                {
                    // Jeśli brak wybranego wpisu, wyczyść podgląd
                    if (pdfViewer.Document != null)
                    {
                        pdfViewer.Document.Dispose();
                        pdfViewer.Document = null;
                    }
                    return;
                }

                byte[] pdfBytes = GeneratePdf();

                using (var stream = new MemoryStream(pdfBytes))
                {   
                    // usuwa dok pdf - który potem podmieni
                    if (pdfViewer.Document != null)
                    {
                        pdfViewer.Document.Dispose();
                        pdfViewer.Document = null;
                    }
                    pdfViewer.Document = PdfDocument.Load(stream);

                    pdfViewer.Refresh();
                    pdfViewer.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd wyświetlania PDF: {ex.Message}");
            }
        }

        private byte[] GeneratePdf()
        {
            using (var stream = new MemoryStream())
            {
                Rectangle pageSize = PageSize.A4.Rotate(); // poziomo
                var document = new Document(pageSize, 10, 10, 10, 10); // margines 10
                var writer = PdfWriter.GetInstance(document, stream);
                document.Open();
                AddContent(document, writer);
                document.Close();
                return stream.ToArray();
            }
        }

        private void AddContent(Document document, PdfWriter writer)  // zawartość pliku pdf
        {
            BaseFont baseFont = BaseFont.CreateFont(
                BaseFont.HELVETICA,
                BaseFont.CP1250,
                BaseFont.NOT_EMBEDDED
            );

            Font titleFont = new Font(baseFont, 14, iTextSharp.text.Font.BOLD);  // Font nie jest jednoznaczne
            Font normalFont = new Font(baseFont, 11);
            Font boldFont = new Font(baseFont, 11, iTextSharp.text.Font.BOLD);

            float availableHeight = document.PageSize.Height - document.TopMargin - document.BottomMargin;
            float halfHeight = availableHeight / 2;  // dla lini przerywanej na środku

            PdfPTable mainTable = new PdfPTable(1) { WidthPercentage = 100 };

            // pierwsza kopia:
            mainTable.AddCell(new PdfPCell(CreateDocumentCopy("Pierwsza kopia - dla klienta", titleFont, normalFont, boldFont))
            {
                Border = Rectangle.NO_BORDER,
                FixedHeight = halfHeight - 10
            });

            // linia przerywana
            mainTable.AddCell(new PdfPCell()
            {
                Border = Rectangle.NO_BORDER,
                FixedHeight = 20f,
                CellEvent = new CenteredLineCellEvent(writer.DirectContent)
            });

            // druga kopia
            mainTable.AddCell(new PdfPCell(CreateDocumentCopy("Druga kopia - dla sewisu", titleFont, normalFont, boldFont))
            {
                Border = Rectangle.NO_BORDER,
                FixedHeight = halfHeight - 10
            });

            document.Add(mainTable);
        }

        private PdfPTable CreateDocumentCopy(string copyLabel, Font titleFont, Font normalFont, Font boldFont)
        {
            PdfPTable copyTable = new PdfPTable(1)
            {
                WidthPercentage = 100
            };

            // Tytuł i data
            var headerTable = new PdfPTable(1);
            headerTable.AddCell(new PdfPCell(new Phrase("Karta serwisowa", titleFont))
            {
                Border = Rectangle.NO_BORDER,
                HorizontalAlignment = Element.ALIGN_CENTER
            });
            headerTable.AddCell(new PdfPCell(new Phrase($"Wrocław, dnia: {DateTime.Now:dd.MM.yyyy}", normalFont))
            {
                Border = Rectangle.NO_BORDER,
                HorizontalAlignment = Element.ALIGN_RIGHT
            });
            copyTable.AddCell(new PdfPCell(headerTable) { Border = Rectangle.NO_BORDER });

            // dane
            var dataTable = new PdfPTable(2) { WidthPercentage = 100 };
            dataTable.SetWidths(new float[] { 30, 70 });  // stosunek szerokości

            string serviceCode = GenerateServiceCode(selectedEntry.Id, selectedEntry.Client.Id);

            AddTableRow(dataTable, "Klient:", $"{selectedEntry.Client.Imie} {selectedEntry.Client.Nazwisko}", boldFont, normalFont);
            AddTableRow(dataTable, "Model telefonu:", selectedEntry.Model.PelnaNazwa, boldFont, normalFont);
            AddTableRow(dataTable, "Numer IMEI:", selectedEntry.IMEI ?? "brak", boldFont, normalFont);
            AddTableRow(dataTable, "Opis usterki:", selectedEntry.Opis ?? "brak opisu", boldFont, normalFont);
            AddTableRow(dataTable, "Szacowany koszt:", selectedEntry.CenaWstepna?.ToString("0.00 zł") ?? "brak", boldFont, normalFont);
            AddTableRow(dataTable, "Cena ostateczna:", selectedEntry.CenaKoncowa?.ToString("0.00 zł") ?? "brak", boldFont, normalFont);
            AddTableRow(dataTable, "Kod serwisowy:", serviceCode, boldFont, normalFont);

            PdfPCell emptyCell1 = new PdfPCell(new Phrase(" ")) { Border = Rectangle.NO_BORDER, FixedHeight = 12f };
            PdfPCell emptyCell2 = new PdfPCell(new Phrase(" ")) { Border = Rectangle.NO_BORDER, FixedHeight = 12f }; // linia odstępu
            dataTable.AddCell(emptyCell1);
            dataTable.AddCell(emptyCell2);

            copyTable.AddCell(new PdfPCell(dataTable) { Border = Rectangle.NO_BORDER });

            // miejsce na podpisy
            var signatureTable = new PdfPTable(2) { WidthPercentage = 100 };
            signatureTable.AddCell(new PdfPCell(new Phrase("Podpis serwisanta:", normalFont))
            {
                Border = Rectangle.TOP_BORDER,
                PaddingTop = 40f,
                HorizontalAlignment = Element.ALIGN_CENTER
            });
            signatureTable.AddCell(new PdfPCell(new Phrase("Podpis klienta:", normalFont))
            {
                Border = Rectangle.TOP_BORDER,
                PaddingTop = 40f,
                HorizontalAlignment = Element.ALIGN_CENTER
            });
            copyTable.AddCell(new PdfPCell(signatureTable) { Border = Rectangle.NO_BORDER });

            return copyTable;
        }

        private void AddTableRow(PdfPTable table, string label, string value, Font labelFont, Font valueFont)
        {
            table.AddCell(new PdfPCell(new Phrase(label, labelFont)) { Border = Rectangle.NO_BORDER });
            table.AddCell(new PdfPCell(new Phrase(value, valueFont)) { Border = Rectangle.NO_BORDER });
        }

        private class CenteredLineCellEvent : IPdfPCellEvent  // interface "przyczepiający się" pod etap rysowania, żeby dodać własne elementy
        {
            private readonly PdfContentByte contentByte;

            public CenteredLineCellEvent(PdfContentByte cb) => contentByte = cb;

            public void CellLayout(PdfPCell cell, Rectangle position, PdfContentByte[] canvases)
            {
                var canvas = canvases[PdfPTable.LINECANVAS];
                canvas.SaveState();
                canvas.SetLineDash(3f, 3f); // 3 "jednostki" kreski, 3 "jednostki" odstępu
                float centerY = position.Top - (position.Height / 2);
                canvas.MoveTo(0, centerY);                                  // od lewej
                canvas.LineTo(canvas.PdfDocument.PageSize.Width, centerY);  // do prawej
                canvas.Stroke();        // narysuj
                canvas.RestoreState();
            }
        }
    }
}