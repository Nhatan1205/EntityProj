namespace EntityProj.Forms
{
    partial class UCProductBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProductBuy));
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRate = new Guna.UI2.WinForms.Guna2Button();
            this.lblProductCondition = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.pbProduct = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.panelBody.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelBody.BorderRadius = 10;
            this.panelBody.BorderThickness = 1;
            this.panelBody.Controls.Add(this.guna2Panel1);
            this.panelBody.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.panelBody.Size = new System.Drawing.Size(1491, 114);
            this.panelBody.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnRate);
            this.guna2Panel1.Controls.Add(this.lblProductCondition);
            this.guna2Panel1.Controls.Add(this.lblSellerName);
            this.guna2Panel1.Controls.Add(this.pbProduct);
            this.guna2Panel1.Controls.Add(this.lblProductName);
            this.guna2Panel1.Controls.Add(this.btnCancel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(11, 4);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1476, 106);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnRate
            // 
            this.btnRate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnRate.BorderThickness = 1;
            this.btnRate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnRate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnRate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnRate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnRate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRate.Location = new System.Drawing.Point(1188, 48);
            this.btnRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(121, 37);
            this.btnRate.TabIndex = 57;
            this.btnRate.Text = "Rate";
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // lblProductCondition
            // 
            this.lblProductCondition.AllowParentOverrides = false;
            this.lblProductCondition.AutoEllipsis = false;
            this.lblProductCondition.BackColor = System.Drawing.Color.DarkGray;
            this.lblProductCondition.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblProductCondition.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblProductCondition.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblProductCondition.Location = new System.Drawing.Point(1049, 55);
            this.lblProductCondition.Margin = new System.Windows.Forms.Padding(4);
            this.lblProductCondition.Name = "lblProductCondition";
            this.lblProductCondition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductCondition.Size = new System.Drawing.Size(108, 30);
            this.lblProductCondition.TabIndex = 60;
            this.lblProductCondition.Text = "Completed";
            this.lblProductCondition.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProductCondition.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblSellerName
            // 
            this.lblSellerName.BackColor = System.Drawing.Color.Transparent;
            this.lblSellerName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblSellerName.Location = new System.Drawing.Point(109, 55);
            this.lblSellerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(551, 30);
            this.lblSellerName.TabIndex = 119;
            this.lblSellerName.Text = "Seller Name";
            // 
            // pbProduct
            // 
            this.pbProduct.AllowFocused = false;
            this.pbProduct.AutoSizeHeight = true;
            this.pbProduct.BorderRadius = 0;
            this.pbProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbProduct.Image = ((System.Drawing.Image)(resources.GetObject("pbProduct.Image")));
            this.pbProduct.IsCircle = true;
            this.pbProduct.Location = new System.Drawing.Point(0, 0);
            this.pbProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(101, 101);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduct.TabIndex = 63;
            this.pbProduct.TabStop = false;
            this.pbProduct.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblProductName.Location = new System.Drawing.Point(109, 15);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(923, 30);
            this.lblProductName.TabIndex = 118;
            this.lblProductName.Text = "Product Name";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnCancel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1188, 48);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 37);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(1069, 12);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(383, 30);
            this.lblPrice.TabIndex = 66;
            this.lblPrice.Text = "100000000 VND";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDetail
            // 
            this.btnDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.BorderThickness = 1;
            this.btnDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetail.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnDetail.Location = new System.Drawing.Point(1339, 52);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(115, 37);
            this.btnDetail.TabIndex = 65;
            this.btnDetail.Text = "Detail";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // UCProductBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.panelBody);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCProductBuy";
            this.Size = new System.Drawing.Size(1491, 114);
            this.Load += new System.EventHandler(this.UCProductBuy_Load);
            this.MouseEnter += new System.EventHandler(this.UCProductBuy_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCProductBuy_MouseLeave);
            this.panelBody.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel panelBody;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;

        public Bunifu.UI.WinForms.BunifuPictureBox pbProduct;
        public Bunifu.UI.WinForms.BunifuLabel lblProductCondition;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblSellerName;
        public System.Windows.Forms.Label lblProductName;
        public Guna.UI2.WinForms.Guna2Button btnCancel;
        public Guna.UI2.WinForms.Guna2Button btnDetail;
        public Guna.UI2.WinForms.Guna2Button btnRate;
    }
}
