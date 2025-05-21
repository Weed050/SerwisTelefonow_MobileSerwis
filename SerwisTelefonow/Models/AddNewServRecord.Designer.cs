namespace SerwisTelefonow.Models
{
    partial class AddNewServRecord
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhone = new Label();
            lblBrand = new Label();
            lblModel = new Label();
            lblIMEI = new Label();
            lblEstimatedPrice = new Label();
            lblDescription = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtIMEI = new TextBox();
            txtEstimatedPrice = new TextBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(706, 142);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(140, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Imię";
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(706, 142);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(140, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Nazwisko";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(706, 142);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(140, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Telefon";
            // 
            // lblBrand
            // 
            lblBrand.Location = new Point(706, 142);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(140, 20);
            lblBrand.TabIndex = 6;
            lblBrand.Text = "Marka telefonu";
            // 
            // lblModel
            // 
            lblModel.Location = new Point(706, 142);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(140, 20);
            lblModel.TabIndex = 8;
            lblModel.Text = "Model";
            // 
            // lblIMEI
            // 
            lblIMEI.Location = new Point(706, 142);
            lblIMEI.Name = "lblIMEI";
            lblIMEI.Size = new Size(140, 20);
            lblIMEI.TabIndex = 10;
            lblIMEI.Text = "IMEI (opcjonalnie)";
            // 
            // lblEstimatedPrice
            // 
            lblEstimatedPrice.Location = new Point(706, 142);
            lblEstimatedPrice.Name = "lblEstimatedPrice";
            lblEstimatedPrice.Size = new Size(140, 20);
            lblEstimatedPrice.TabIndex = 12;
            lblEstimatedPrice.Text = "Wstępna cena (PLN)";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(706, 142);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(140, 20);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Opis usterki";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(866, 142);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(866, 142);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 23);
            txtLastName.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(866, 142);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 23);
            txtPhone.TabIndex = 5;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(866, 142);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(250, 23);
            txtBrand.TabIndex = 7;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(866, 142);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(250, 23);
            txtModel.TabIndex = 9;
            // 
            // txtIMEI
            // 
            txtIMEI.Location = new Point(866, 142);
            txtIMEI.Name = "txtIMEI";
            txtIMEI.Size = new Size(250, 23);
            txtIMEI.TabIndex = 11;
            // 
            // txtEstimatedPrice
            // 
            txtEstimatedPrice.Location = new Point(866, 142);
            txtEstimatedPrice.Name = "txtEstimatedPrice";
            txtEstimatedPrice.Size = new Size(250, 23);
            txtEstimatedPrice.TabIndex = 13;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(866, 142);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 60);
            txtDescription.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(786, 582);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 35);
            btnSave.TabIndex = 16;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(946, 582);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddNewServRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1338, 820);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblBrand);
            Controls.Add(txtBrand);
            Controls.Add(lblModel);
            Controls.Add(txtModel);
            Controls.Add(lblIMEI);
            Controls.Add(txtIMEI);
            Controls.Add(lblEstimatedPrice);
            Controls.Add(txtEstimatedPrice);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "AddNewServRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zgłoszenie naprawy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhone;
        private Label lblBrand;
        private Label lblModel;
        private Label lblIMEI;
        private Label lblEstimatedPrice;
        private Label lblDescription;

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtIMEI;
        private TextBox txtEstimatedPrice;
        private TextBox txtDescription;

        private Button btnSave;
        private Button btnCancel;
    }
}