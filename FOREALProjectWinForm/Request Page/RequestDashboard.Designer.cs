namespace FOREALProjectWinForm
{
    partial class RequestDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestDashboard));
            this.txtFullAddress = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.submitRequest = new System.Windows.Forms.Button();
            this.namedonatorLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameRequest = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFullAddress
            // 
            this.txtFullAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtFullAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtFullAddress.ForeColor = System.Drawing.Color.White;
            this.txtFullAddress.Location = new System.Drawing.Point(466, 258);
            this.txtFullAddress.Multiline = true;
            this.txtFullAddress.Name = "txtFullAddress";
            this.txtFullAddress.Size = new System.Drawing.Size(200, 20);
            this.txtFullAddress.TabIndex = 20;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContactNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtContactNumber.ForeColor = System.Drawing.Color.White;
            this.txtContactNumber.Location = new System.Drawing.Point(467, 310);
            this.txtContactNumber.Multiline = true;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(199, 20);
            this.txtContactNumber.TabIndex = 19;
            // 
            // submitRequest
            // 
            this.submitRequest.BackColor = System.Drawing.Color.Cyan;
            this.submitRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.submitRequest.Location = new System.Drawing.Point(343, 393);
            this.submitRequest.Name = "submitRequest";
            this.submitRequest.Size = new System.Drawing.Size(185, 50);
            this.submitRequest.TabIndex = 17;
            this.submitRequest.Text = "Request";
            this.submitRequest.UseVisualStyleBackColor = false;
            this.submitRequest.Click += new System.EventHandler(this.submitRequest_Click);
            // 
            // namedonatorLabel
            // 
            this.namedonatorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.namedonatorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.namedonatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namedonatorLabel.ForeColor = System.Drawing.Color.Cyan;
            this.namedonatorLabel.Location = new System.Drawing.Point(232, 205);
            this.namedonatorLabel.Name = "namedonatorLabel";
            this.namedonatorLabel.Size = new System.Drawing.Size(172, 20);
            this.namedonatorLabel.TabIndex = 22;
            this.namedonatorLabel.Text = "Name";
            this.namedonatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationLabel
            // 
            this.locationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.locationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.locationLabel.ForeColor = System.Drawing.Color.Cyan;
            this.locationLabel.Location = new System.Drawing.Point(232, 258);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(172, 20);
            this.locationLabel.TabIndex = 23;
            this.locationLabel.Text = "Full Address";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(232, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Contact Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameRequest
            // 
            this.txtNameRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtNameRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameRequest.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNameRequest.ForeColor = System.Drawing.Color.White;
            this.txtNameRequest.Location = new System.Drawing.Point(466, 205);
            this.txtNameRequest.Multiline = true;
            this.txtNameRequest.Name = "txtNameRequest";
            this.txtNameRequest.Size = new System.Drawing.Size(199, 20);
            this.txtNameRequest.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(466, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 1);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(467, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 1);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(467, 329);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 1);
            this.panel4.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // RequestDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(921, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.namedonatorLabel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtFullAddress);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtNameRequest);
            this.Controls.Add(this.submitRequest);
            this.Name = "RequestDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOREAL Request";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullAddress;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Button submitRequest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label namedonatorLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameRequest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}