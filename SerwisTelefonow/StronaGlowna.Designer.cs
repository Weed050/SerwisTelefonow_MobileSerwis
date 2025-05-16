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
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAdminPanel
            // 
            buttonAdminPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdminPanel.BackColor = Color.SteelBlue;
            buttonAdminPanel.Cursor = Cursors.Hand;
            buttonAdminPanel.FlatAppearance.BorderSize = 0;
            buttonAdminPanel.FlatStyle = FlatStyle.Flat;
            buttonAdminPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonAdminPanel.ForeColor = Color.White;
            buttonAdminPanel.Location = new Point(614, 12);
            buttonAdminPanel.Name = "buttonAdminPanel";
            buttonAdminPanel.Size = new Size(174, 35);
            buttonAdminPanel.TabIndex = 0;
            buttonAdminPanel.Text = "Panel Administratora";
            buttonAdminPanel.UseVisualStyleBackColor = false;
            buttonAdminPanel.Click += buttonAdminPanel_Click;
            // 
            // labelMobileSerwisTitle
            // 
            labelMobileSerwisTitle.Anchor = AnchorStyles.Top;
            labelMobileSerwisTitle.AutoSize = true;
            labelMobileSerwisTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelMobileSerwisTitle.ForeColor = Color.SteelBlue;
            labelMobileSerwisTitle.Location = new Point(79, 20);
            labelMobileSerwisTitle.Margin = new Padding(3, 0, 3, 20);
            labelMobileSerwisTitle.Name = "labelMobileSerwisTitle";
            labelMobileSerwisTitle.Size = new Size(287, 54);
            labelMobileSerwisTitle.TabIndex = 1;
            labelMobileSerwisTitle.Text = "Mobile Serwis";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(23, 94);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(283, 80);
            label1.TabIndex = 2;
            label1.Text = "W celu sprawdzenia postępu naprawy \r\nzachęcamy do skorzystania z poniższego \r\nformularza. Prosimy podać login i hasło \r\nzamieszczone na karcie serwisowej:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(labelMobileSerwisTitle);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(162, 18);
            flowLayoutPanel1.MinimumSize = new Size(446, 420);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.Size = new Size(446, 420);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(23, 197);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(400, 200);
            panel1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(120, 80);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(200, 30);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(30, 83);
            label3.Name = "label3";
            label3.Size = new Size(53, 23);
            label3.TabIndex = 5;
            label3.Text = "Hasło";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(30, 33);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 4;
            label2.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(120, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 30);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(150, 130);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 7;
            button2.Text = "Sprawdź";
            button2.UseVisualStyleBackColor = false;
            // 
            // StronaGlowna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(buttonAdminPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 400);
            Name = "StronaGlowna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mobile Serwis";
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
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
