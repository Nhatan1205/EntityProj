namespace EntityProj.Forms
{
    partial class UCProductCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProductCart));
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cbSelected = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.lblPrice = new Bunifu.UI.WinForms.BunifuLabel();
            this.pbProduct = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelBody.BorderRadius = 10;
            this.panelBody.BorderThickness = 1;
            this.panelBody.Controls.Add(this.lblSellerName);
            this.panelBody.Controls.Add(this.lblProductName);
            this.panelBody.Controls.Add(this.cbSelected);
            this.panelBody.Controls.Add(this.btnDetail);
            this.panelBody.Controls.Add(this.btnDelete);
            this.panelBody.Controls.Add(this.lblPrice);
            this.panelBody.Controls.Add(this.pbProduct);
            this.panelBody.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(780, 96);
            this.panelBody.TabIndex = 0;
            // 
            // lblSellerName
            // 
            this.lblSellerName.BackColor = System.Drawing.Color.Transparent;
            this.lblSellerName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSellerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblSellerName.Location = new System.Drawing.Point(118, 54);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(443, 27);
            this.lblSellerName.TabIndex = 133;
            this.lblSellerName.Text = "Seller name";
            this.lblSellerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblProductName.Location = new System.Drawing.Point(117, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(443, 54);
            this.lblProductName.TabIndex = 132;
            this.lblProductName.Text = "Product name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProductName.Click += new System.EventHandler(this.lblProductName_Click);
            // 
            // cbSelected
            // 
            this.cbSelected.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbSelected.CheckedState.BorderRadius = 6;
            this.cbSelected.CheckedState.BorderThickness = 1;
            this.cbSelected.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.cbSelected.Location = new System.Drawing.Point(5, 33);
            this.cbSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSelected.Name = "cbSelected";
            this.cbSelected.Size = new System.Drawing.Size(22, 24);
            this.cbSelected.TabIndex = 71;
            this.cbSelected.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbSelected.UncheckedState.BorderRadius = 6;
            this.cbSelected.UncheckedState.BorderThickness = 1;
            this.cbSelected.UncheckedState.FillColor = System.Drawing.Color.White;
            this.cbSelected.CheckedChanged += new System.EventHandler(this.cbSelected_CheckedChanged);
            this.cbSelected.Click += new System.EventHandler(this.cbSelected_Click);
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
            this.btnDetail.Location = new System.Drawing.Point(684, 50);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(86, 30);
            this.btnDetail.TabIndex = 67;
            this.btnDetail.Text = "Detail";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(579, 50);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 30);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AllowParentOverrides = false;
            this.lblPrice.AutoEllipsis = false;
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrice.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblPrice.Location = new System.Drawing.Point(640, 16);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(130, 23);
            this.lblPrice.TabIndex = 65;
            this.lblPrice.Text = "100.000.000 VND";
            this.lblPrice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pbProduct
            // 
            this.pbProduct.AllowFocused = false;
            this.pbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbProduct.AutoSizeHeight = true;
            this.pbProduct.BorderRadius = 0;
            this.pbProduct.Image = ((System.Drawing.Image)(resources.GetObject("pbProduct.Image")));
            this.pbProduct.IsCircle = true;
            this.pbProduct.Location = new System.Drawing.Point(34, 4);
            this.pbProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(79, 79);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduct.TabIndex = 64;
            this.pbProduct.TabStop = false;
            this.pbProduct.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // UCProductCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBody);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 3);
            this.Name = "UCProductCart";
            this.Size = new System.Drawing.Size(780, 96);
            this.Load += new System.EventHandler(this.UCProductCart_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private Guna.UI2.WinForms.Guna2Button btnDetail;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        public Bunifu.UI.WinForms.BunifuLabel lblPrice;
        public Bunifu.UI.WinForms.BunifuPictureBox pbProduct;
        public Guna.UI2.WinForms.Guna2CustomCheckBox cbSelected;
        public System.Windows.Forms.Label lblProductName;
        public System.Windows.Forms.Label lblSellerName;
    }
}
