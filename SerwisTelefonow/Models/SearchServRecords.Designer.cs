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
            labelTitle = new Label();
            dataGridViewServRecords = new DataGridView();
            buttonRefresh = new Button();
            groupBoxServRecords = new GroupBox();

            ((System.ComponentModel.ISupportInitialize)dataGridViewServRecords).BeginInit();
            groupBoxServRecords.SuspendLayout();
            SuspendLayout();

            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelTitle.ForeColor = Color.SteelBlue;
            labelTitle.Location = new Point(500, 0); // Dopasuj do własnego układu
            labelTitle.Margin = new Padding(4, 0, 4, 19);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(605, 51);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Historia Napraw Serwisowych";

            // 
            // dataGridViewServRecords
            // 
            dataGridViewServRecords.AllowUserToAddRows = false;
            dataGridViewServRecords.AllowUserToDeleteRows = false;
            dataGridViewServRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewServRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServRecords.BackgroundColor = Color.White;
            dataGridViewServRecords.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewServRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServRecords.Location = new Point(18, 60);
            dataGridViewServRecords.Margin = new Padding(18, 15, 18, 15);
            dataGridViewServRecords.MultiSelect = false;
            dataGridViewServRecords.Name = "dataGridViewServRecords";
            dataGridViewServRecords.ReadOnly = true;
            dataGridViewServRecords.RowHeadersWidth = 51;
            dataGridViewServRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServRecords.Size = new Size(1600, 540);
            dataGridViewServRecords.TabIndex = 1;

            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.SteelBlue;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(750, 615); // środek
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(140, 38);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Odśwież";
            buttonRefresh.UseVisualStyleBackColor = false;

            // 
            // groupBoxServRecords
            // 
            groupBoxServRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxServRecords.Controls.Add(labelTitle);
            groupBoxServRecords.Controls.Add(dataGridViewServRecords);
            groupBoxServRecords.Controls.Add(buttonRefresh);
            groupBoxServRecords.Location = new Point(12, 12);
            groupBoxServRecords.Name = "groupBoxServRecords";
            groupBoxServRecords.Size = new Size(1630, 670);
            groupBoxServRecords.TabIndex = 3;
            groupBoxServRecords.TabStop = false;

            // 
            // SearchServRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1654, 694);
            Controls.Add(groupBoxServRecords);
            Name = "SearchServRecords";
            Text = "Mobile Serwis - Historia Napraw";
            ((System.ComponentModel.ISupportInitialize)dataGridViewServRecords).EndInit();
            groupBoxServRecords.ResumeLayout(false);
            groupBoxServRecords.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private DataGridView dataGridViewServRecords;
        private Button buttonRefresh;
        private GroupBox groupBoxServRecords;
    }
}
