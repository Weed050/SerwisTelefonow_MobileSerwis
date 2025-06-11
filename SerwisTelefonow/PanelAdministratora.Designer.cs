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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            dodajSerwisToolStripMenuItem = new ToolStripMenuItem();
            dodajWpisSerwisuToolStripMenuItem = new ToolStripMenuItem();
            przegladajWpisyToolStripMenuItem = new ToolStripMenuItem();
            wylogujSięToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            wydrukujZgłoszenieToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, dodajSerwisToolStripMenuItem, wylogujSięToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1200, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // dodajSerwisToolStripMenuItem
            // 
            dodajSerwisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajWpisSerwisuToolStripMenuItem, przegladajWpisyToolStripMenuItem, wydrukujZgłoszenieToolStripMenuItem });
            dodajSerwisToolStripMenuItem.Name = "dodajSerwisToolStripMenuItem";
            dodajSerwisToolStripMenuItem.Size = new Size(72, 24);
            dodajSerwisToolStripMenuItem.Text = "&Serwisy";
            // 
            // dodajWpisSerwisuToolStripMenuItem
            // 
            dodajWpisSerwisuToolStripMenuItem.Name = "dodajWpisSerwisuToolStripMenuItem";
            dodajWpisSerwisuToolStripMenuItem.Size = new Size(228, 26);
            dodajWpisSerwisuToolStripMenuItem.Text = "&Dodaj wpis serwisu";
            dodajWpisSerwisuToolStripMenuItem.Click += dodajWpisSerwisuToolStripMenuItem_Click;
            // 
            // przegladajWpisyToolStripMenuItem
            // 
            przegladajWpisyToolStripMenuItem.Name = "przegladajWpisyToolStripMenuItem";
            przegladajWpisyToolStripMenuItem.Size = new Size(228, 26);
            przegladajWpisyToolStripMenuItem.Text = "P&rzegladaj wpisy";
            przegladajWpisyToolStripMenuItem.Click += przegladajWpisyToolStripMenuItem_Click;
            // 
            // wylogujSięToolStripMenuItem
            // 
            wylogujSięToolStripMenuItem.Name = "wylogujSięToolStripMenuItem";
            wylogujSięToolStripMenuItem.Size = new Size(100, 24);
            wylogujSięToolStripMenuItem.Text = "Wyloguj się";
            wylogujSięToolStripMenuItem.Click += wylogujSięToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 30);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 770);
            panel1.TabIndex = 3;
            // 
            // wydrukujZgłoszenieToolStripMenuItem
            // 
            wydrukujZgłoszenieToolStripMenuItem.Name = "wydrukujZgłoszenieToolStripMenuItem";
            wydrukujZgłoszenieToolStripMenuItem.Size = new Size(228, 26);
            wydrukujZgłoszenieToolStripMenuItem.Text = "Wydrukuj zgłoszenie";
            wydrukujZgłoszenieToolStripMenuItem.Click += wydrukujZgłoszenieToolStripMenuItem_Click;
            // 
            // PanelAdministratora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 800);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 598);
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
        private Panel panel1;
        private ToolStripMenuItem wylogujSięToolStripMenuItem;
        private ToolStripMenuItem wydrukujZgłoszenieToolStripMenuItem;
    }
}