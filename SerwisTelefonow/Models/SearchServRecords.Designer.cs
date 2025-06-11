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
            buttonDeleteClientRow = new Button();
            buttonDeleteServEntrRow = new Button();
            buttonSaveServEntry = new Button();
            buttonSaveClientData = new Button();
            dataGridViewClients = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dataGridViewPhoneModel = new DataGridView();
            label2 = new Label();
            buttonSaveModel = new Button();
            buttonDeletePhoneModel = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhoneModel).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelTitle.ForeColor = Color.SteelBlue;
            labelTitle.Location = new Point(221, 23);
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
            dataGridViewServRecords.Location = new Point(68, 106);
            dataGridViewServRecords.Margin = new Padding(21, 20, 21, 20);
            dataGridViewServRecords.MultiSelect = false;
            dataGridViewServRecords.Name = "dataGridViewServRecords";
            dataGridViewServRecords.RowHeadersWidth = 51;
            dataGridViewServRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServRecords.Size = new Size(974, 295);
            dataGridViewServRecords.TabIndex = 1;
            // 
            // buttonDeleteClientRow
            // 
            buttonDeleteClientRow.Location = new Point(400, 364);
            buttonDeleteClientRow.Name = "buttonDeleteClientRow";
            buttonDeleteClientRow.Size = new Size(124, 29);
            buttonDeleteClientRow.TabIndex = 8;
            buttonDeleteClientRow.Text = "Usuń wpis";
            buttonDeleteClientRow.UseVisualStyleBackColor = true;
            buttonDeleteClientRow.Click += buttonDeleteClientRow_Click;
            // 
            // buttonDeleteServEntrRow
            // 
            buttonDeleteServEntrRow.Location = new Point(548, 424);
            buttonDeleteServEntrRow.Name = "buttonDeleteServEntrRow";
            buttonDeleteServEntrRow.Size = new Size(124, 29);
            buttonDeleteServEntrRow.TabIndex = 7;
            buttonDeleteServEntrRow.Text = "Usuń wpis";
            buttonDeleteServEntrRow.UseVisualStyleBackColor = true;
            buttonDeleteServEntrRow.Click += buttonDeleteServEntrRow_Click;
            // 
            // buttonSaveServEntry
            // 
            buttonSaveServEntry.Location = new Point(405, 424);
            buttonSaveServEntry.Name = "buttonSaveServEntry";
            buttonSaveServEntry.Size = new Size(124, 29);
            buttonSaveServEntry.TabIndex = 6;
            buttonSaveServEntry.Text = "Zapisz zmiany";
            buttonSaveServEntry.UseVisualStyleBackColor = true;
            buttonSaveServEntry.Click += buttonSaveServEntry_Click;
            // 
            // buttonSaveClientData
            // 
            buttonSaveClientData.Location = new Point(257, 364);
            buttonSaveClientData.Name = "buttonSaveClientData";
            buttonSaveClientData.Size = new Size(124, 29);
            buttonSaveClientData.TabIndex = 5;
            buttonSaveClientData.Text = "Zapisz zmiany";
            buttonSaveClientData.UseVisualStyleBackColor = true;
            buttonSaveClientData.Click += buttonSaveClientData_Click;
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
            dataGridViewClients.Location = new Point(70, 97);
            dataGridViewClients.Margin = new Padding(21, 20, 21, 20);
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.Size = new Size(602, 244);
            dataGridViewClients.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(224, 23);
            label1.Margin = new Padding(5, 0, 5, 25);
            label1.Name = "label1";
            label1.Size = new Size(335, 62);
            label1.TabIndex = 3;
            label1.Text = "Lista Klientów";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewServRecords);
            groupBox1.Controls.Add(labelTitle);
            groupBox1.Controls.Add(buttonDeleteServEntrRow);
            groupBox1.Controls.Add(buttonSaveServEntry);
            groupBox1.Location = new Point(275, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1110, 472);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewClients);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(buttonSaveClientData);
            groupBox2.Controls.Add(buttonDeleteClientRow);
            groupBox2.Location = new Point(900, 520);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(728, 423);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewPhoneModel);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(buttonSaveModel);
            groupBox3.Controls.Add(buttonDeletePhoneModel);
            groupBox3.Location = new Point(42, 520);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(728, 423);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            // 
            // dataGridViewPhoneModel
            // 
            dataGridViewPhoneModel.AllowUserToAddRows = false;
            dataGridViewPhoneModel.AllowUserToDeleteRows = false;
            dataGridViewPhoneModel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPhoneModel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPhoneModel.BackgroundColor = Color.White;
            dataGridViewPhoneModel.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewPhoneModel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPhoneModel.Location = new Point(96, 97);
            dataGridViewPhoneModel.Margin = new Padding(21, 20, 21, 20);
            dataGridViewPhoneModel.MultiSelect = false;
            dataGridViewPhoneModel.Name = "dataGridViewPhoneModel";
            dataGridViewPhoneModel.RowHeadersWidth = 51;
            dataGridViewPhoneModel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPhoneModel.Size = new Size(540, 270);
            dataGridViewPhoneModel.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(96, 23);
            label2.Margin = new Padding(5, 0, 5, 25);
            label2.Name = "label2";
            label2.Size = new Size(536, 62);
            label2.TabIndex = 3;
            label2.Text = "Lista Modeli Telefonów";
            // 
            // buttonSaveModel
            // 
            buttonSaveModel.Location = new Point(253, 376);
            buttonSaveModel.Name = "buttonSaveModel";
            buttonSaveModel.Size = new Size(124, 29);
            buttonSaveModel.TabIndex = 5;
            buttonSaveModel.Text = "Zapisz zmiany";
            buttonSaveModel.UseVisualStyleBackColor = true;
            buttonSaveModel.Click += buttonSaveModel_Click;
            // 
            // buttonDeletePhoneModel
            // 
            buttonDeletePhoneModel.Location = new Point(401, 376);
            buttonDeletePhoneModel.Name = "buttonDeletePhoneModel";
            buttonDeletePhoneModel.Size = new Size(124, 29);
            buttonDeletePhoneModel.TabIndex = 8;
            buttonDeletePhoneModel.Text = "Usuń wpis";
            buttonDeletePhoneModel.UseVisualStyleBackColor = true;
            buttonDeletePhoneModel.Click += buttonDeletePhoneModel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1457, 317);
            button1.Name = "button1";
            button1.Size = new Size(124, 29);
            button1.TabIndex = 12;
            button1.Text = "odświerz dane";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SearchServRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1890, 965);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SearchServRecords";
            Text = "Mobile Serwis - Historia Napraw";
            ((System.ComponentModel.ISupportInitialize)dataGridViewServRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhoneModel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private DataGridView dataGridViewServRecords;
        private Label label1;
        private DataGridView dataGridViewClients;
        private Button buttonSaveServEntry;
        private Button buttonSaveClientData;
        private Button buttonDeleteServEntrRow;
        private Button buttonDeleteClientRow;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridViewPhoneModel;
        private Label label2;
        private Button buttonSaveModel;
        private Button buttonDeletePhoneModel;
        private Button button1;
    }
}
