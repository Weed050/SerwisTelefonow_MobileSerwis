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
            labelMobileSerwisTitle = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelMobileSerwisTitle
            // 
            labelMobileSerwisTitle.Anchor = AnchorStyles.Top;
            labelMobileSerwisTitle.AutoSize = true;
            labelMobileSerwisTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelMobileSerwisTitle.ForeColor = Color.SteelBlue;
            labelMobileSerwisTitle.Location = new Point(23, 20);
            labelMobileSerwisTitle.Margin = new Padding(3, 0, 3, 20);
            labelMobileSerwisTitle.Name = "labelMobileSerwisTitle";
            labelMobileSerwisTitle.Size = new Size(287, 54);
            labelMobileSerwisTitle.TabIndex = 1;
            labelMobileSerwisTitle.Text = "Mobile Serwis";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(labelMobileSerwisTitle);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.MinimumSize = new Size(800, 450);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.Size = new Size(800, 450);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.WrapContents = false;
            // 
            // PanelAdministratora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 400);
            Name = "PanelAdministratora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mobile Serwis";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelMobileSerwisTitle;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}