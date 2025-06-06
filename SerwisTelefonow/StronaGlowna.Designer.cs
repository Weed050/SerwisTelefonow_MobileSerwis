using System.Windows.Forms;

namespace SerwisTelefonow
{
    partial class StronaGlowna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StronaGlowna));
            buttonAdminPanel = new Button();
            labelMobileSerwisTitle = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            textBoxPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBoxLogin = new TextBox();
            buttonCheck = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAdminPanel
            // 
            buttonAdminPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdminPanel.BackColor = Color.FromArgb(0, 120, 215);
            buttonAdminPanel.Cursor = Cursors.Hand;
            buttonAdminPanel.FlatAppearance.BorderSize = 0;
            buttonAdminPanel.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 90, 170);
            buttonAdminPanel.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 150, 255);
            buttonAdminPanel.FlatStyle = FlatStyle.Flat;
            buttonAdminPanel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonAdminPanel.ForeColor = Color.White;
            buttonAdminPanel.Location = new Point(1157, 20);
            buttonAdminPanel.Margin = new Padding(4, 5, 4, 5);
            buttonAdminPanel.Name = "buttonAdminPanel";
            buttonAdminPanel.Size = new Size(223, 40);
            buttonAdminPanel.TabIndex = 0;
            buttonAdminPanel.Text = "Panel Administratora";
            buttonAdminPanel.UseVisualStyleBackColor = false;
            buttonAdminPanel.Click += buttonAdminPanel_Click;
            // 
            // labelMobileSerwisTitle
            // 
            labelMobileSerwisTitle.Anchor = AnchorStyles.Top;
            labelMobileSerwisTitle.AutoSize = true;
            labelMobileSerwisTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelMobileSerwisTitle.ForeColor = Color.FromArgb(0, 120, 215);
            labelMobileSerwisTitle.Location = new Point(81, 25);
            labelMobileSerwisTitle.Margin = new Padding(4, 0, 4, 20);
            labelMobileSerwisTitle.Name = "labelMobileSerwisTitle";
            labelMobileSerwisTitle.Size = new Size(337, 62);
            labelMobileSerwisTitle.TabIndex = 1;
            labelMobileSerwisTitle.Text = "Mobile Serwis";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(24, 107);
            label1.Margin = new Padding(4, 0, 4, 30);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(452, 100);
            label1.TabIndex = 2;
            label1.Text = "W celu sprawdzenia postępu naprawy \r\nzachęcamy do skorzystania z poniższego \r\nformularza. Prosimy podać login i hasło \r\nzamieszczone na karcie serwisowej:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(labelMobileSerwisTitle);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(500, 150);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.MinimumSize = new Size(500, 400);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 25, 20, 25);
            flowLayoutPanel1.Size = new Size(500, 482);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxLogin);
            panel1.Controls.Add(buttonCheck);
            panel1.Location = new Point(30, 237);
            panel1.Margin = new Padding(10, 0, 10, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(25, 20, 25, 20);
            panel1.Size = new Size(440, 220);
            panel1.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxPassword.Location = new Point(150, 90);
            textBoxPassword.Margin = new Padding(4, 5, 4, 5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '•';
            textBoxPassword.Size = new Size(240, 32);
            textBoxPassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(50, 90);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 5;
            label3.Text = "Hasło:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(50, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 4;
            label2.Text = "Login:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxLogin.Location = new Point(150, 37);
            textBoxLogin.Margin = new Padding(4, 5, 4, 5);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(240, 32);
            textBoxLogin.TabIndex = 3;
            // 
            // buttonCheck
            // 
            buttonCheck.BackColor = Color.FromArgb(0, 120, 215);
            buttonCheck.Cursor = Cursors.Hand;
            buttonCheck.FlatAppearance.BorderSize = 0;
            buttonCheck.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 90, 170);
            buttonCheck.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 150, 255);
            buttonCheck.FlatStyle = FlatStyle.Flat;
            buttonCheck.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonCheck.ForeColor = Color.White;
            buttonCheck.Location = new Point(150, 150);
            buttonCheck.Margin = new Padding(4, 5, 4, 5);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(140, 40);
            buttonCheck.TabIndex = 7;
            buttonCheck.Text = "Sprawdź";
            buttonCheck.UseVisualStyleBackColor = false;
            // 
            // StronaGlowna
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 250);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 800);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(buttonAdminPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(800, 600);
            Name = "StronaGlowna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mobile Serwis";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdminPanel;
        private Label labelMobileSerwisTitle;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private TextBox textBoxPassword;
        private Label label3;
        private Label label2;
        private TextBox textBoxLogin;
        private Button buttonCheck;
    }
}
