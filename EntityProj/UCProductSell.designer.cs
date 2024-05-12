namespace EntityProj.Forms
{
    partial class UCProductSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProductSell));
            this.pbProduct = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblBuyerName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPrice = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblProductCondition = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnFunction = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.lblProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
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
            this.pbProduct.Location = new System.Drawing.Point(12, 9);
            this.pbProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(105, 105);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduct.TabIndex = 36;
            this.pbProduct.TabStop = false;
            this.pbProduct.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.pbProduct.Click += new System.EventHandler(this.pbProduct_Click);
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AllowParentOverrides = false;
            this.lblBuyerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBuyerName.AutoEllipsis = false;
            this.lblBuyerName.CursorType = null;
            this.lblBuyerName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblBuyerName.Location = new System.Drawing.Point(149, 63);
            this.lblBuyerName.Margin = new System.Windows.Forms.Padding(4);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBuyerName.Size = new System.Drawing.Size(124, 31);
            this.lblBuyerName.TabIndex = 35;
            this.lblBuyerName.Text = "Buyer Name";
            this.lblBuyerName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblBuyerName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblBuyerName.Click += new System.EventHandler(this.lblSellerName_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AllowParentOverrides = false;
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoEllipsis = false;
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrice.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblPrice.Location = new System.Drawing.Point(1044, 15);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(169, 30);
            this.lblPrice.TabIndex = 32;
            this.lblPrice.Text = "100.000.000 VND";
            this.lblPrice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblProductCondition
            // 
            this.lblProductCondition.AllowParentOverrides = false;
            this.lblProductCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductCondition.AutoEllipsis = false;
            this.lblProductCondition.BackColor = System.Drawing.Color.DarkGray;
            this.lblProductCondition.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblProductCondition.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblProductCondition.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblProductCondition.Location = new System.Drawing.Point(535, 64);
            this.lblProductCondition.Margin = new System.Windows.Forms.Padding(4);
            this.lblProductCondition.Name = "lblProductCondition";
            this.lblProductCondition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductCondition.Size = new System.Drawing.Size(108, 30);
            this.lblProductCondition.TabIndex = 33;
            this.lblProductCondition.Text = "Completed";
            this.lblProductCondition.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProductCondition.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblProductCondition.Click += new System.EventHandler(this.lblProductCondition_Click);
            // 
            // btnFunction
            // 
            this.btnFunction.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnFunction.BorderThickness = 1;
            this.btnFunction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFunction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFunction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFunction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFunction.FillColor = System.Drawing.Color.BlueViolet;
            this.btnFunction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnFunction.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFunction.HoverState.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnFunction.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnFunction.HoverState.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnFunction.Location = new System.Drawing.Point(715, 57);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(230, 37);
            this.btnFunction.TabIndex = 57;
            this.btnFunction.Text = "Next state";
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(967, 57);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 37);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnDetail.Location = new System.Drawing.Point(1106, 57);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(119, 37);
            this.btnDetail.TabIndex = 59;
            this.btnDetail.Text = "Detail";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblProductName.Location = new System.Drawing.Point(143, 15);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(643, 30);
            this.lblProductName.TabIndex = 119;
            this.lblProductName.Text = "Product Name";
            // 
            // UCProductSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.lblBuyerName);
            this.Controls.Add(this.lblProductCondition);
            this.Controls.Add(this.lblPrice);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCProductSell";
            this.Size = new System.Drawing.Size(1241, 118);
            this.Load += new System.EventHandler(this.UCProductSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.UI.WinForms.BunifuPictureBox pbProduct;
        public Bunifu.UI.WinForms.BunifuLabel lblBuyerName;
        public Bunifu.UI.WinForms.BunifuLabel lblPrice;
        public Bunifu.UI.WinForms.BunifuLabel lblProductCondition;
        public Guna.UI2.WinForms.Guna2Button btnFunction;
        public Guna.UI2.WinForms.Guna2Button btnCancel;
        public Guna.UI2.WinForms.Guna2Button btnDetail;
        public System.Windows.Forms.Label lblProductName;
    }
}
