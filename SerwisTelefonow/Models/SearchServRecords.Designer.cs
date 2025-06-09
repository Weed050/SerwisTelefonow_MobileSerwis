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
            dataGridViewClients = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServRecords).BeginInit();
            groupBoxServRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelTitle.ForeColor = Color.SteelBlue;
            labelTitle.Location = new Point(571, 0);
            labelTitle.Margin = new Padding(5, 0, 5, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(684, 62);
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
            dataGridViewServRecords.Location = new Point(21, 80);
            dataGridViewServRecords.Margin = new Padding(21, 20, 21, 20);
            dataGridViewServRecords.MultiSelect = false;
            dataGridViewServRecords.Name = "dataGridViewServRecords";
            dataGridViewServRecords.ReadOnly = true;
            dataGridViewServRecords.RowHeadersWidth = 51;
            dataGridViewServRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServRecords.Size = new Size(1829, 301);
            dataGridViewServRecords.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.SteelBlue;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(856, 834);
            buttonRefresh.Margin = new Padding(3, 4, 3, 4);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(160, 51);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Odśwież";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // groupBoxServRecords
            // 
            groupBoxServRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxServRecords.Controls.Add(dataGridViewClients);
            groupBoxServRecords.Controls.Add(label1);
            groupBoxServRecords.Controls.Add(labelTitle);
            groupBoxServRecords.Controls.Add(dataGridViewServRecords);
            groupBoxServRecords.Controls.Add(buttonRefresh);
            groupBoxServRecords.Location = new Point(14, 16);
            groupBoxServRecords.Margin = new Padding(3, 4, 3, 4);
            groupBoxServRecords.Name = "groupBoxServRecords";
            groupBoxServRecords.Padding = new Padding(3, 4, 3, 4);
            groupBoxServRecords.Size = new Size(1863, 893);
            groupBoxServRecords.TabIndex = 3;
            groupBoxServRecords.TabStop = false;
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.AllowUserToDeleteRows = false;
            dataGridViewClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClients.BackgroundColor = Color.White;
            dataGridViewClients.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(80, 495);
            dataGridViewClients.Margin = new Padding(21, 20, 21, 20);
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.ReadOnly = true;
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.Size = new Size(1649, 301);
            dataGridViewClients.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(772, 401);
            label1.Margin = new Padding(5, 0, 5, 25);
            label1.Name = "label1";
            label1.Size = new Size(335, 62);
            label1.TabIndex = 3;
            label1.Text = "Lista Klientów";
            // 
            // SearchServRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1890, 925);
            Controls.Add(groupBoxServRecords);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SearchServRecords";
            Text = "Mobile Serwis - Historia Napraw";
            ((System.ComponentModel.ISupportInitialize)dataGridViewServRecords).EndInit();
            groupBoxServRecords.ResumeLayout(false);
            groupBoxServRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private DataGridView dataGridViewServRecords;
        private Button buttonRefresh;
        private GroupBox groupBoxServRecords;
        private Label label1;
        private DataGridView dataGridViewClients;
    }
}
