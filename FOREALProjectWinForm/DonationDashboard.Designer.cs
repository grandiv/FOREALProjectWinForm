namespace FOREALProjectWinForm
{
    partial class DonationDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonationDashboard));
            this.namedonatorLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.foodtypeLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.submitDonation = new System.Windows.Forms.Button();
            this.txtNameDonator = new System.Windows.Forms.TextBox();
            this.txtFoodType = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.expdateLabel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // namedonatorLabel
            // 
            this.namedonatorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.namedonatorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.namedonatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namedonatorLabel.ForeColor = System.Drawing.Color.Cyan;
            this.namedonatorLabel.Location = new System.Drawing.Point(232, 174);
            this.namedonatorLabel.Name = "namedonatorLabel";
            this.namedonatorLabel.Size = new System.Drawing.Size(172, 20);
            this.namedonatorLabel.TabIndex = 0;
            this.namedonatorLabel.Text = "Name";
            this.namedonatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationLabel
            // 
            this.locationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.locationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.locationLabel.ForeColor = System.Drawing.Color.Cyan;
            this.locationLabel.Location = new System.Drawing.Point(232, 228);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(172, 20);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.Text = "Location";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodtypeLabel
            // 
            this.foodtypeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.foodtypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.foodtypeLabel.ForeColor = System.Drawing.Color.Cyan;
            this.foodtypeLabel.Location = new System.Drawing.Point(232, 281);
            this.foodtypeLabel.Name = "foodtypeLabel";
            this.foodtypeLabel.Size = new System.Drawing.Size(172, 20);
            this.foodtypeLabel.TabIndex = 2;
            this.foodtypeLabel.Text = "Food Type";
            this.foodtypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityLabel
            // 
            this.quantityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.quantityLabel.ForeColor = System.Drawing.Color.Cyan;
            this.quantityLabel.Location = new System.Drawing.Point(232, 333);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(172, 20);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Quantity";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitDonation
            // 
            this.submitDonation.BackColor = System.Drawing.Color.Cyan;
            this.submitDonation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitDonation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.submitDonation.Location = new System.Drawing.Point(343, 445);
            this.submitDonation.Name = "submitDonation";
            this.submitDonation.Size = new System.Drawing.Size(185, 50);
            this.submitDonation.TabIndex = 5;
            this.submitDonation.Text = "Donate";
            this.submitDonation.UseVisualStyleBackColor = false;
            this.submitDonation.Click += new System.EventHandler(this.SubmitDonation_Click);
            // 
            // txtNameDonator
            // 
            this.txtNameDonator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtNameDonator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameDonator.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNameDonator.ForeColor = System.Drawing.Color.White;
            this.txtNameDonator.Location = new System.Drawing.Point(466, 174);
            this.txtNameDonator.Multiline = true;
            this.txtNameDonator.Name = "txtNameDonator";
            this.txtNameDonator.Size = new System.Drawing.Size(199, 20);
            this.txtNameDonator.TabIndex = 6;
            // 
            // txtFoodType
            // 
            this.txtFoodType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtFoodType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtFoodType.ForeColor = System.Drawing.Color.White;
            this.txtFoodType.Location = new System.Drawing.Point(466, 281);
            this.txtFoodType.Multiline = true;
            this.txtFoodType.Name = "txtFoodType";
            this.txtFoodType.Size = new System.Drawing.Size(199, 20);
            this.txtFoodType.TabIndex = 7;
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtLocation.ForeColor = System.Drawing.Color.White;
            this.txtLocation.Location = new System.Drawing.Point(466, 228);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(199, 20);
            this.txtLocation.TabIndex = 9;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtQuantity.ForeColor = System.Drawing.Color.White;
            this.txtQuantity.Location = new System.Drawing.Point(466, 333);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(199, 20);
            this.txtQuantity.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(466, 390);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // expdateLabel
            // 
            this.expdateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.expdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.expdateLabel.ForeColor = System.Drawing.Color.Cyan;
            this.expdateLabel.Location = new System.Drawing.Point(232, 390);
            this.expdateLabel.Name = "expdateLabel";
            this.expdateLabel.Size = new System.Drawing.Size(172, 20);
            this.expdateLabel.TabIndex = 12;
            this.expdateLabel.Text = "Expiration Date";
            this.expdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(466, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 1);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(466, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 1);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(466, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 1);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(466, 352);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 1);
            this.panel4.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // DonationDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(921, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.expdateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtFoodType);
            this.Controls.Add(this.txtNameDonator);
            this.Controls.Add(this.submitDonation);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.foodtypeLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.namedonatorLabel);
            this.Name = "DonationDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOREAL Donation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namedonatorLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label foodtypeLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button submitDonation;
        private System.Windows.Forms.TextBox txtNameDonator;
        private System.Windows.Forms.TextBox txtFoodType;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label expdateLabel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}