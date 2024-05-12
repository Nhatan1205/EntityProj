namespace EntityProj.Forms
{
    partial class UCShipping
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBorder = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblRecipientName = new System.Windows.Forms.Label();
            this.panelBody.SuspendLayout();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelBorder);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.panelBody.Size = new System.Drawing.Size(1000, 218);
            this.panelBody.TabIndex = 0;
            // 
            // panelBorder
            // 
            this.panelBorder.BorderColor = System.Drawing.Color.Silver;
            this.panelBorder.BorderRadius = 10;
            this.panelBorder.BorderThickness = 1;
            this.panelBorder.Controls.Add(this.guna2PictureBox3);
            this.panelBorder.Controls.Add(this.guna2PictureBox2);
            this.panelBorder.Controls.Add(this.guna2PictureBox1);
            this.panelBorder.Controls.Add(this.lblAddress);
            this.panelBorder.Controls.Add(this.lblPhoneNo);
            this.panelBorder.Controls.Add(this.lblRecipientName);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.Location = new System.Drawing.Point(30, 10);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(940, 198);
            this.panelBorder.TabIndex = 0;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(29, 17);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(30, 30);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 111;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(29, 63);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(30, 30);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 110;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(29, 107);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 109;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(96, 107);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(522, 78);
            this.lblAddress.TabIndex = 75;
            this.lblAddress.Text = "no 1, Vo van Ngan, Thu Duc city";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNo.Location = new System.Drawing.Point(96, 63);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(514, 31);
            this.lblPhoneNo.TabIndex = 74;
            this.lblPhoneNo.Text = "0338866561";
            // 
            // lblRecipientName
            // 
            this.lblRecipientName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipientName.ForeColor = System.Drawing.Color.Black;
            this.lblRecipientName.Location = new System.Drawing.Point(96, 17);
            this.lblRecipientName.Name = "lblRecipientName";
            this.lblRecipientName.Size = new System.Drawing.Size(520, 31);
            this.lblRecipientName.TabIndex = 73;
            this.lblRecipientName.Text = "Tran Trung Tin";
            // 
            // UCShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Name = "UCShipping";
            this.Size = new System.Drawing.Size(1000, 218);
            this.Click += new System.EventHandler(this.UCShipping_Click);
            this.panelBody.ResumeLayout(false);
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel panelBody;
        public Guna.UI2.WinForms.Guna2Panel panelBorder;
        public System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.Label lblPhoneNo;
        public System.Windows.Forms.Label lblRecipientName;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
