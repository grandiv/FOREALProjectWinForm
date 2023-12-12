namespace FOREALProjectWinForm
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDonate = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Volunteer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.Cyan;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRequest.Location = new System.Drawing.Point(524, 291);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(184, 77);
            this.btnRequest.TabIndex = 1;
            this.btnRequest.Text = "Request Food";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.BtnRequest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Food Rescue and Allocation";
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.Cyan;
            this.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDonate.Location = new System.Drawing.Point(226, 291);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(184, 77);
            this.btnDonate.TabIndex = 3;
            this.btnDonate.Text = "Donate Food";
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.BtnDonate_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.ForeColor = System.Drawing.Color.Cyan;
            this.btnLogOut.Location = new System.Drawing.Point(12, 526);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Volunteer
            // 
            this.Volunteer.BackColor = System.Drawing.Color.Cyan;
            this.Volunteer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Volunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Volunteer.Location = new System.Drawing.Point(373, 405);
            this.Volunteer.Name = "Volunteer";
            this.Volunteer.Size = new System.Drawing.Size(184, 77);
            this.Volunteer.TabIndex = 6;
            this.Volunteer.Text = "Be a Volunteer";
            this.Volunteer.UseVisualStyleBackColor = false;
            this.Volunteer.Click += new System.EventHandler(this.Volunteer_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(921, 561);
            this.Controls.Add(this.Volunteer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRequest);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOREAL Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Volunteer;
    }
}