namespace EntityProj.Forms
{
    partial class FCancelInfo
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
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtExtraInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbReason = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.panelProduct = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label = new System.Windows.Forms.Label();
            this.panelBody.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.guna2Panel3);
            this.panelBody.Controls.Add(this.guna2Panel2);
            this.panelBody.Controls.Add(this.panelProduct);
            this.panelBody.Controls.Add(this.panelTop);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(741, 646);
            this.panelBody.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.txtExtraInfo);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.cbReason);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 221);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(741, 352);
            this.guna2Panel3.TabIndex = 3;
            // 
            // txtExtraInfo
            // 
            this.txtExtraInfo.AutoScroll = true;
            this.txtExtraInfo.BackColor = System.Drawing.Color.Transparent;
            this.txtExtraInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExtraInfo.DefaultText = "";
            this.txtExtraInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExtraInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtExtraInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExtraInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExtraInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtExtraInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtExtraInfo.ForeColor = System.Drawing.Color.Black;
            this.txtExtraInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtExtraInfo.Location = new System.Drawing.Point(12, 102);
            this.txtExtraInfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtExtraInfo.Multiline = true;
            this.txtExtraInfo.Name = "txtExtraInfo";
            this.txtExtraInfo.PasswordChar = '\0';
            this.txtExtraInfo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtExtraInfo.PlaceholderText = "eg. My phone has missing headphones";
            this.txtExtraInfo.SelectedText = "";
            this.txtExtraInfo.Size = new System.Drawing.Size(717, 221);
            this.txtExtraInfo.TabIndex = 192;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 30);
            this.label2.TabIndex = 191;
            this.label2.Text = "Additional Information (optional)";
            // 
            // cbReason
            // 
            this.cbReason.BackColor = System.Drawing.Color.Transparent;
            this.cbReason.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbReason.DropDownHeight = 200;
            this.cbReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReason.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.cbReason.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.cbReason.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbReason.ForeColor = System.Drawing.Color.Black;
            this.cbReason.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.cbReason.IntegralHeight = false;
            this.cbReason.ItemHeight = 30;
            this.cbReason.Items.AddRange(new object[] {
            "Select a Reason",
            "Want to add/remove item(s)",
            "Seller requests to cancel",
            "Have issue with/want to change payment method",
            "Delivery is too long",
            "Change of mind",
            "Duplicate order",
            "Change delivery address",
            "Found better price elsewhere"});
            this.cbReason.Location = new System.Drawing.Point(11, 19);
            this.cbReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbReason.Name = "cbReason";
            this.cbReason.Size = new System.Drawing.Size(718, 36);
            this.cbReason.StartIndex = 0;
            this.cbReason.TabIndex = 190;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnSubmit);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 573);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(741, 73);
            this.guna2Panel2.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoRoundedCorners = true;
            this.btnSubmit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnSubmit.BorderRadius = 20;
            this.btnSubmit.BorderThickness = 1;
            this.btnSubmit.CustomizableEdges.BottomLeft = false;
            this.btnSubmit.CustomizableEdges.BottomRight = false;
            this.btnSubmit.CustomizableEdges.TopLeft = false;
            this.btnSubmit.CustomizableEdges.TopRight = false;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnSubmit.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnSubmit.Location = new System.Drawing.Point(498, 16);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(231, 43);
            this.btnSubmit.TabIndex = 90;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.lblPrice);
            this.panelProduct.Controls.Add(this.lblProductName);
            this.panelProduct.Controls.Add(this.guna2Panel1);
            this.panelProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProduct.Location = new System.Drawing.Point(0, 81);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(741, 140);
            this.panelProduct.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(170, 101);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(181, 30);
            this.lblPrice.TabIndex = 121;
            this.lblPrice.Text = "100000000 VND";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblProductName.Location = new System.Drawing.Point(169, 9);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(559, 79);
            this.lblProductName.TabIndex = 120;
            this.lblProductName.Text = "Product Name";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pbProductImage);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Size = new System.Drawing.Size(153, 140);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pbProductImage
            // 
            this.pbProductImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProductImage.ImageRotate = 0F;
            this.pbProductImage.Location = new System.Drawing.Point(4, 4);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(145, 132);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 0;
            this.pbProductImage.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.guna2Separator1);
            this.panelTop.Controls.Add(this.label);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(741, 81);
            this.panelTop.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 52);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(717, 10);
            this.guna2Separator1.TabIndex = 118;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label.Location = new System.Drawing.Point(200, 12);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(238, 31);
            this.label.TabIndex = 117;
            this.label.Text = "Product Cancellation";
            // 
            // FCancelInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 646);
            this.Controls.Add(this.panelBody);
            this.Name = "FCancelInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCancelInfo";
            this.Load += new System.EventHandler(this.FCancelInfo_Load);
            this.panelBody.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.panelProduct.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2Panel panelProduct;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2PictureBox pbProductImage;
        public System.Windows.Forms.Label lblProductName;
        public System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbReason;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtExtraInfo;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
    }
}