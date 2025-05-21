using System.Windows.Forms;

namespace SerwisTelefonow.Models
{
    partial class SearchServRecords
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
            dataGridViewServRecords = new DataGridView();
            labelTitle = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServRecords).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewServRecords
            // 
            dataGridViewServRecords.AllowUserToAddRows = false;
            dataGridViewServRecords.AllowUserToDeleteRows = false;
            dataGridViewServRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewServRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServRecords.BackgroundColor = Color.White;
            dataGridViewServRecords.BorderStyle = BorderStyle.None;
            dataGridViewServRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServRecords.Location = new Point(18, 60);
            dataGridViewServRecords.Margin = new Padding(18, 15, 18, 15);
            dataGridViewServRecords.Name = "dataGridViewServRecords";
            dataGridViewServRecords.ReadOnly = true;
            dataGridViewServRecords.RowHeadersWidth = 51;
            dataGridViewServRecords.Size = new Size(1601, 638);
            dataGridViewServRecords.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelTitle.ForeColor = Color.SteelBlue;
            labelTitle.Location = new Point(18, 15);
            labelTitle.Margin = new Padding(18, 15, 18, 8);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(392, 45);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Historia Napraw Serwisu";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(dataGridViewServRecords);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(18, 15, 18, 15);
            panel1.Size = new Size(1636, 712);
            panel1.TabIndex = 2;
            // 
            // SearchServRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1636, 712);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SearchServRecords";
            Text = "Mobile Serwis - Historia Napraw";
            ((System.ComponentModel.ISupportInitialize)dataGridViewServRecords).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewServRecords;
        private Label labelTitle;
        private Panel panel1;
    }
}