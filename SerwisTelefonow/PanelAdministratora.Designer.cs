namespace SerwisTelefonow
{
    partial class PanelAdministratora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelAdministratora));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            dodajSerwisToolStripMenuItem = new ToolStripMenuItem();
            dodajWpisSerwisuToolStripMenuItem = new ToolStripMenuItem();
            przegladajWpisyToolStripMenuItem = new ToolStripMenuItem();
            fakturyToolStripMenuItem = new ToolStripMenuItem();
            wyświetlFakturyToolStripMenuItem = new ToolStripMenuItem();
            dodajFakturęToolStripMenuItem = new ToolStripMenuItem();
            stanMagazynuToolStripMenuItem = new ToolStripMenuItem();
            sprawdźModelToolStripMenuItem = new ToolStripMenuItem();
            wycenaNaprawyToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, dodajSerwisToolStripMenuItem, fakturyToolStripMenuItem, stanMagazynuToolStripMenuItem, sprawdźModelToolStripMenuItem, wycenaNaprawyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1050, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // dodajSerwisToolStripMenuItem
            // 
            dodajSerwisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajWpisSerwisuToolStripMenuItem, przegladajWpisyToolStripMenuItem });
            dodajSerwisToolStripMenuItem.Name = "dodajSerwisToolStripMenuItem";
            dodajSerwisToolStripMenuItem.Size = new Size(58, 20);
            dodajSerwisToolStripMenuItem.Text = "&Serwisy";
            // 
            // dodajWpisSerwisuToolStripMenuItem
            // 
            dodajWpisSerwisuToolStripMenuItem.Name = "dodajWpisSerwisuToolStripMenuItem";
            dodajWpisSerwisuToolStripMenuItem.Size = new Size(174, 22);
            dodajWpisSerwisuToolStripMenuItem.Text = "&Dodaj wpis serwisu";
            dodajWpisSerwisuToolStripMenuItem.Click += dodajWpisSerwisuToolStripMenuItem_Click;
            // 
            // przegladajWpisyToolStripMenuItem
            // 
            przegladajWpisyToolStripMenuItem.Name = "przegladajWpisyToolStripMenuItem";
            przegladajWpisyToolStripMenuItem.Size = new Size(174, 22);
            przegladajWpisyToolStripMenuItem.Text = "P&rzegladaj wpisy";
            przegladajWpisyToolStripMenuItem.Click += przegladajWpisyToolStripMenuItem_Click;
            // 
            // fakturyToolStripMenuItem
            // 
            fakturyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wyświetlFakturyToolStripMenuItem, dodajFakturęToolStripMenuItem });
            fakturyToolStripMenuItem.Name = "fakturyToolStripMenuItem";
            fakturyToolStripMenuItem.Size = new Size(58, 20);
            fakturyToolStripMenuItem.Text = "&Faktury";
            // 
            // wyświetlFakturyToolStripMenuItem
            // 
            wyświetlFakturyToolStripMenuItem.Name = "wyświetlFakturyToolStripMenuItem";
            wyświetlFakturyToolStripMenuItem.Size = new Size(161, 22);
            wyświetlFakturyToolStripMenuItem.Text = "&Wyświetl faktury";
            wyświetlFakturyToolStripMenuItem.Click += wyświetlFakturyToolStripMenuItem_Click;
            // 
            // dodajFakturęToolStripMenuItem
            // 
            dodajFakturęToolStripMenuItem.Name = "dodajFakturęToolStripMenuItem";
            dodajFakturęToolStripMenuItem.Size = new Size(161, 22);
            dodajFakturęToolStripMenuItem.Text = "&Dodaj fakturę";
            dodajFakturęToolStripMenuItem.Click += dodajFakturęToolStripMenuItem_Click;
            // 
            // stanMagazynuToolStripMenuItem
            // 
            stanMagazynuToolStripMenuItem.Name = "stanMagazynuToolStripMenuItem";
            stanMagazynuToolStripMenuItem.Size = new Size(100, 20);
            stanMagazynuToolStripMenuItem.Text = "St&an Magazynu";
            // 
            // sprawdźModelToolStripMenuItem
            // 
            sprawdźModelToolStripMenuItem.Name = "sprawdźModelToolStripMenuItem";
            sprawdźModelToolStripMenuItem.Size = new Size(100, 20);
            sprawdźModelToolStripMenuItem.Text = "Sp&rawdź model";
            sprawdźModelToolStripMenuItem.Click += sprawdźModelToolStripMenuItem_Click;
            // 
            // wycenaNaprawyToolStripMenuItem
            // 
            wycenaNaprawyToolStripMenuItem.Name = "wycenaNaprawyToolStripMenuItem";
            wycenaNaprawyToolStripMenuItem.Size = new Size(109, 20);
            wycenaNaprawyToolStripMenuItem.Text = "Wy&cena naprawy";
            wycenaNaprawyToolStripMenuItem.Click += wycenaNaprawyToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 576);
            panel1.TabIndex = 3;
            // 
            // PanelAdministratora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1050, 600);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(702, 460);
            Name = "PanelAdministratora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mobile Serwis";
            WindowState = FormWindowState.Maximized;
            FormClosing += PanelAdministratora_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem dodajSerwisToolStripMenuItem;
        private ToolStripMenuItem dodajWpisSerwisuToolStripMenuItem;
        private ToolStripMenuItem przegladajWpisyToolStripMenuItem;
        private ToolStripMenuItem fakturyToolStripMenuItem;
        private ToolStripMenuItem wyświetlFakturyToolStripMenuItem;
        private ToolStripMenuItem dodajFakturęToolStripMenuItem;
        private ToolStripMenuItem stanMagazynuToolStripMenuItem;
        private ToolStripMenuItem sprawdźModelToolStripMenuItem;
        private ToolStripMenuItem wycenaNaprawyToolStripMenuItem;
        private Panel panel1;
    }
}