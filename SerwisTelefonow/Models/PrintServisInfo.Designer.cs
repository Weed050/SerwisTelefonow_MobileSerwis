namespace SerwisTelefonow.Models
{
    partial class PrintServisInfo
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewServRecords).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewServRecords
            // 
            dataGridViewServRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServRecords.Dock = DockStyle.Fill;
            dataGridViewServRecords.Location = new Point(0, 0);
            dataGridViewServRecords.MultiSelect = false;
            dataGridViewServRecords.Name = "dataGridViewServRecords";
            dataGridViewServRecords.RowHeadersWidth = 51;
            dataGridViewServRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServRecords.Size = new Size(1493, 771);
            dataGridViewServRecords.TabIndex = 0;
            dataGridViewServRecords.SelectionChanged += dataGridViewServRecords_SelectionChanged;
            // 
            // PrintServisInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1493, 771);
            Controls.Add(dataGridViewServRecords);
            Name = "PrintServisInfo";
            Text = "PrintServisInfo";
            ((System.ComponentModel.ISupportInitialize)dataGridViewServRecords).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewServRecords;
    }
}