using SerwisTelefonow.Data;
using System.Reflection.Metadata;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace SerwisTelefonow.Models
{
    public partial class PrintServisInfo : Form
    {
        private readonly AppDbContext context;
        public PrintServisInfo(AppDbContext _context)
        {
            InitializeComponent();
        }
        public void GeneratePdf(string filePath)
        {
            // Utworzenie dokumentu PDF
            iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // Dodanie przykładowych elementów
            document.Add(new Paragraph("Karta serwisowa"));
            document.Add(new Paragraph("Data: " + DateTime.Now.ToShortDateString()));
            document.Add(new Paragraph("Informacje dla klienta:"));
            document.Add(new Paragraph("...")); // tutaj wstaw resztę danych

            document.Close();
        }
    }
}
