namespace EntityProj.Forms
{
    partial class FRating
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblRate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNameProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.rtStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.txtComment = new Guna.UI2.WinForms.Guna2TextBox();
            this.chbReliable = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbGoodProduct = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbPoliteFriendly = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbSatisfied = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbOntimeDelivery = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbTrueDescription = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panelCheckBox = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.panelCheckBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = false;
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblRate.Location = new System.Drawing.Point(12, 14);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(340, 41);
            this.lblRate.TabIndex = 15;
            this.lblRate.Text = "Rating for the product";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblNameProduct);
            this.guna2Panel1.Controls.Add(this.pbProduct);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 71);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(612, 87);
            this.guna2Panel1.TabIndex = 17;
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = false;
            this.lblNameProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblNameProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProduct.Location = new System.Drawing.Point(98, 0);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(514, 58);
            this.lblNameProduct.TabIndex = 17;
            this.lblNameProduct.Text = "yujyukyuyui";
            // 
            // pbProduct
            // 
            this.pbProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbProduct.ImageRotate = 0F;
            this.pbProduct.Location = new System.Drawing.Point(0, 0);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(98, 87);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduct.TabIndex = 16;
            this.pbProduct.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.lblStatus);
            this.guna2Panel2.Controls.Add(this.lblQuality);
            this.guna2Panel2.Controls.Add(this.rtStar);
            this.guna2Panel2.Location = new System.Drawing.Point(12, 176);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(612, 70);
            this.guna2Panel2.TabIndex = 18;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStatus.Location = new System.Drawing.Point(433, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Tuyệt vời";
            // 
            // lblQuality
            // 
            this.lblQuality.BackColor = System.Drawing.Color.Transparent;
            this.lblQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuality.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQuality.Location = new System.Drawing.Point(15, 14);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(158, 43);
            this.lblQuality.TabIndex = 3;
            this.lblQuality.Text = "Product Quality";
            // 
            // rtStar
            // 
            this.rtStar.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.rtStar.Location = new System.Drawing.Point(193, 12);
            this.rtStar.Name = "rtStar";
            this.rtStar.RatingColor = System.Drawing.Color.Yellow;
            this.rtStar.Size = new System.Drawing.Size(188, 45);
            this.rtStar.TabIndex = 1;
            this.rtStar.ValueChanged += new System.EventHandler(this.rtStar_ValueChanged);
            // 
            // btnSend
            // 
            this.btnSend.AutoRoundedCorners = true;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnSend.BorderRadius = 23;
            this.btnSend.BorderThickness = 1;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnSend.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnSend.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSend.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnSend.Location = new System.Drawing.Point(496, 479);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(113, 49);
            this.btnSend.TabIndex = 54;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtComment
            // 
            this.txtComment.AutoScroll = true;
            this.txtComment.BackColor = System.Drawing.Color.Transparent;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.DefaultText = "";
            this.txtComment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComment.ForeColor = System.Drawing.Color.Black;
            this.txtComment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtComment.Location = new System.Drawing.Point(12, 329);
            this.txtComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtComment.PlaceholderText = "Other Comment";
            this.txtComment.SelectedText = "";
            this.txtComment.Size = new System.Drawing.Size(612, 141);
            this.txtComment.TabIndex = 79;
            // 
            // chbReliable
            // 
            this.chbReliable.AutoSize = true;
            this.chbReliable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbReliable.CheckedState.BorderRadius = 0;
            this.chbReliable.CheckedState.BorderThickness = 0;
            this.chbReliable.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbReliable.Location = new System.Drawing.Point(243, 12);
            this.chbReliable.Name = "chbReliable";
            this.chbReliable.Size = new System.Drawing.Size(80, 20);
            this.chbReliable.TabIndex = 80;
            this.chbReliable.Text = "Reliable";
            this.chbReliable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbReliable.UncheckedState.BorderRadius = 0;
            this.chbReliable.UncheckedState.BorderThickness = 0;
            this.chbReliable.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chbGoodProduct
            // 
            this.chbGoodProduct.AutoSize = true;
            this.chbGoodProduct.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbGoodProduct.CheckedState.BorderRadius = 0;
            this.chbGoodProduct.CheckedState.BorderThickness = 0;
            this.chbGoodProduct.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbGoodProduct.Location = new System.Drawing.Point(414, 12);
            this.chbGoodProduct.Name = "chbGoodProduct";
            this.chbGoodProduct.Size = new System.Drawing.Size(112, 20);
            this.chbGoodProduct.TabIndex = 80;
            this.chbGoodProduct.Text = "Good Product";
            this.chbGoodProduct.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbGoodProduct.UncheckedState.BorderRadius = 0;
            this.chbGoodProduct.UncheckedState.BorderThickness = 0;
            this.chbGoodProduct.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chbPoliteFriendly
            // 
            this.chbPoliteFriendly.AutoSize = true;
            this.chbPoliteFriendly.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbPoliteFriendly.CheckedState.BorderRadius = 0;
            this.chbPoliteFriendly.CheckedState.BorderThickness = 0;
            this.chbPoliteFriendly.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbPoliteFriendly.Location = new System.Drawing.Point(69, 38);
            this.chbPoliteFriendly.Name = "chbPoliteFriendly";
            this.chbPoliteFriendly.Size = new System.Drawing.Size(135, 20);
            this.chbPoliteFriendly.TabIndex = 80;
            this.chbPoliteFriendly.Text = "Polite and friendly";
            this.chbPoliteFriendly.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbPoliteFriendly.UncheckedState.BorderRadius = 0;
            this.chbPoliteFriendly.UncheckedState.BorderThickness = 0;
            this.chbPoliteFriendly.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chbSatisfied
            // 
            this.chbSatisfied.AutoSize = true;
            this.chbSatisfied.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbSatisfied.CheckedState.BorderRadius = 0;
            this.chbSatisfied.CheckedState.BorderThickness = 0;
            this.chbSatisfied.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbSatisfied.Location = new System.Drawing.Point(414, 38);
            this.chbSatisfied.Name = "chbSatisfied";
            this.chbSatisfied.Size = new System.Drawing.Size(81, 20);
            this.chbSatisfied.TabIndex = 80;
            this.chbSatisfied.Text = "Satisfied";
            this.chbSatisfied.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbSatisfied.UncheckedState.BorderRadius = 0;
            this.chbSatisfied.UncheckedState.BorderThickness = 0;
            this.chbSatisfied.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chbOntimeDelivery
            // 
            this.chbOntimeDelivery.AutoSize = true;
            this.chbOntimeDelivery.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbOntimeDelivery.CheckedState.BorderRadius = 0;
            this.chbOntimeDelivery.CheckedState.BorderThickness = 0;
            this.chbOntimeDelivery.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbOntimeDelivery.Location = new System.Drawing.Point(243, 38);
            this.chbOntimeDelivery.Name = "chbOntimeDelivery";
            this.chbOntimeDelivery.Size = new System.Drawing.Size(125, 20);
            this.chbOntimeDelivery.TabIndex = 80;
            this.chbOntimeDelivery.Text = "Delivery on time";
            this.chbOntimeDelivery.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbOntimeDelivery.UncheckedState.BorderRadius = 0;
            this.chbOntimeDelivery.UncheckedState.BorderThickness = 0;
            this.chbOntimeDelivery.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chbTrueDescription
            // 
            this.chbTrueDescription.AutoSize = true;
            this.chbTrueDescription.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbTrueDescription.CheckedState.BorderRadius = 0;
            this.chbTrueDescription.CheckedState.BorderThickness = 0;
            this.chbTrueDescription.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbTrueDescription.Location = new System.Drawing.Point(69, 12);
            this.chbTrueDescription.Name = "chbTrueDescription";
            this.chbTrueDescription.Size = new System.Drawing.Size(140, 20);
            this.chbTrueDescription.TabIndex = 80;
            this.chbTrueDescription.Text = "True to description";
            this.chbTrueDescription.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbTrueDescription.UncheckedState.BorderRadius = 0;
            this.chbTrueDescription.UncheckedState.BorderThickness = 0;
            this.chbTrueDescription.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // panelCheckBox
            // 
            this.panelCheckBox.Controls.Add(this.chbReliable);
            this.panelCheckBox.Controls.Add(this.chbSatisfied);
            this.panelCheckBox.Controls.Add(this.chbTrueDescription);
            this.panelCheckBox.Controls.Add(this.chbGoodProduct);
            this.panelCheckBox.Controls.Add(this.chbOntimeDelivery);
            this.panelCheckBox.Controls.Add(this.chbPoliteFriendly);
            this.panelCheckBox.Location = new System.Drawing.Point(12, 253);
            this.panelCheckBox.Name = "panelCheckBox";
            this.panelCheckBox.Size = new System.Drawing.Size(612, 69);
            this.panelCheckBox.TabIndex = 81;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 30;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // FRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(636, 540);
            this.Controls.Add(this.panelCheckBox);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblRate);
            this.Name = "FRating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRating";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.panelCheckBox.ResumeLayout(false);
            this.panelCheckBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRate;
        private Guna.UI2.WinForms.Guna2PictureBox pbProduct;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNameProduct;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2RatingStar rtStar;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2TextBox txtComment;
        private Guna.UI2.WinForms.Guna2CheckBox chbSatisfied;
        private Guna.UI2.WinForms.Guna2CheckBox chbGoodProduct;
        private Guna.UI2.WinForms.Guna2CheckBox chbPoliteFriendly;
        private Guna.UI2.WinForms.Guna2CheckBox chbOntimeDelivery;
        private Guna.UI2.WinForms.Guna2CheckBox chbReliable;
        private Guna.UI2.WinForms.Guna2CheckBox chbTrueDescription;
        private Guna.UI2.WinForms.Guna2Panel panelCheckBox;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}