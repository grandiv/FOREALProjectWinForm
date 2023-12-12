namespace FOREALProjectWinForm
{
    partial class VolunteerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolunteerDashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.namedonatorLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNameVolunteer = new System.Windows.Forms.TextBox();
            this.submitVolunteer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtContactNumVol = new System.Windows.Forms.TextBox();
            this.VolOps = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // namedonatorLabel
            // 
            this.namedonatorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.namedonatorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.namedonatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namedonatorLabel.ForeColor = System.Drawing.Color.Cyan;
            this.namedonatorLabel.Location = new System.Drawing.Point(209, 205);
            this.namedonatorLabel.Name = "namedonatorLabel";
            this.namedonatorLabel.Size = new System.Drawing.Size(195, 20);
            this.namedonatorLabel.TabIndex = 20;
            this.namedonatorLabel.Text = "Name";
            this.namedonatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(467, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 1);
            this.panel1.TabIndex = 22;
            // 
            // txtNameVolunteer
            // 
            this.txtNameVolunteer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtNameVolunteer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameVolunteer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNameVolunteer.ForeColor = System.Drawing.Color.White;
            this.txtNameVolunteer.Location = new System.Drawing.Point(467, 205);
            this.txtNameVolunteer.Multiline = true;
            this.txtNameVolunteer.Name = "txtNameVolunteer";
            this.txtNameVolunteer.Size = new System.Drawing.Size(199, 20);
            this.txtNameVolunteer.TabIndex = 21;
            // 
            // submitVolunteer
            // 
            this.submitVolunteer.BackColor = System.Drawing.Color.Cyan;
            this.submitVolunteer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitVolunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.submitVolunteer.Location = new System.Drawing.Point(343, 393);
            this.submitVolunteer.Name = "submitVolunteer";
            this.submitVolunteer.Size = new System.Drawing.Size(185, 50);
            this.submitVolunteer.TabIndex = 23;
            this.submitVolunteer.Text = "Submit";
            this.submitVolunteer.UseVisualStyleBackColor = false;
            this.submitVolunteer.Click += new System.EventHandler(this.submitVolunteer_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(209, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Contact Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(467, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 1);
            this.panel2.TabIndex = 27;
            // 
            // txtContactNumVol
            // 
            this.txtContactNumVol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtContactNumVol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContactNumVol.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtContactNumVol.ForeColor = System.Drawing.Color.White;
            this.txtContactNumVol.Location = new System.Drawing.Point(467, 258);
            this.txtContactNumVol.Multiline = true;
            this.txtContactNumVol.Name = "txtContactNumVol";
            this.txtContactNumVol.Size = new System.Drawing.Size(199, 20);
            this.txtContactNumVol.TabIndex = 26;
            // 
            // VolOps
            // 
            this.VolOps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.VolOps.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VolOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.VolOps.ForeColor = System.Drawing.Color.Cyan;
            this.VolOps.Location = new System.Drawing.Point(205, 312);
            this.VolOps.Name = "VolOps";
            this.VolOps.Size = new System.Drawing.Size(199, 21);
            this.VolOps.TabIndex = 28;
            this.VolOps.Text = "You Want To Deliver";
            this.VolOps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(467, 312);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.TabIndex = 30;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // VolunteerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(921, 561);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.VolOps);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtContactNumVol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitVolunteer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNameVolunteer);
            this.Controls.Add(this.namedonatorLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VolunteerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOREAL Volunteer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label namedonatorLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNameVolunteer;
        private System.Windows.Forms.Button submitVolunteer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtContactNumVol;
        private System.Windows.Forms.Label VolOps;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnExit;
    }
}