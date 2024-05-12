namespace EntityProj.Forms
{
    partial class FAddVoucher
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
            this.txtVoucherValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtVoucherName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label = new System.Windows.Forms.Label();
            this.lblVoucherName = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.dtEndDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtBeginday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnPost = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtVoucherValue
            // 
            this.txtVoucherValue.AutoScroll = true;
            this.txtVoucherValue.BackColor = System.Drawing.Color.Transparent;
            this.txtVoucherValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVoucherValue.DefaultText = "";
            this.txtVoucherValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVoucherValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVoucherValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVoucherValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVoucherValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtVoucherValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVoucherValue.ForeColor = System.Drawing.Color.Black;
            this.txtVoucherValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtVoucherValue.Location = new System.Drawing.Point(12, 242);
            this.txtVoucherValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVoucherValue.Name = "txtVoucherValue";
            this.txtVoucherValue.PasswordChar = '\0';
            this.txtVoucherValue.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtVoucherValue.PlaceholderText = "Value (VND)";
            this.txtVoucherValue.SelectedText = "";
            this.txtVoucherValue.Size = new System.Drawing.Size(508, 43);
            this.txtVoucherValue.TabIndex = 106;
            this.txtVoucherValue.TextChanged += new System.EventHandler(this.txtVoucherValue_TextChanged);
            this.txtVoucherValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoucherValue_KeyPress);
            // 
            // txtVoucherName
            // 
            this.txtVoucherName.AutoScroll = true;
            this.txtVoucherName.BackColor = System.Drawing.Color.Transparent;
            this.txtVoucherName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVoucherName.DefaultText = "";
            this.txtVoucherName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVoucherName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVoucherName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVoucherName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVoucherName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtVoucherName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVoucherName.ForeColor = System.Drawing.Color.Black;
            this.txtVoucherName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.txtVoucherName.Location = new System.Drawing.Point(12, 130);
            this.txtVoucherName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVoucherName.Name = "txtVoucherName";
            this.txtVoucherName.PasswordChar = '\0';
            this.txtVoucherName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtVoucherName.PlaceholderText = "Title";
            this.txtVoucherName.SelectedText = "";
            this.txtVoucherName.Size = new System.Drawing.Size(509, 43);
            this.txtVoucherName.TabIndex = 105;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label.Location = new System.Drawing.Point(13, 33);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(238, 31);
            this.label.TabIndex = 116;
            this.label.Text = "Voucher information";
            // 
            // lblVoucherName
            // 
            this.lblVoucherName.AutoSize = true;
            this.lblVoucherName.BackColor = System.Drawing.Color.Transparent;
            this.lblVoucherName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoucherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblVoucherName.Location = new System.Drawing.Point(13, 82);
            this.lblVoucherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoucherName.Name = "lblVoucherName";
            this.lblVoucherName.Size = new System.Drawing.Size(160, 31);
            this.lblVoucherName.TabIndex = 117;
            this.lblVoucherName.Text = "Voucher name";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BackColor = System.Drawing.Color.Transparent;
            this.lblValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblValue.Location = new System.Drawing.Point(13, 190);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(69, 31);
            this.lblValue.TabIndex = 118;
            this.lblValue.Text = "Value";
            // 
            // dtEndDay
            // 
            this.dtEndDay.BackColor = System.Drawing.Color.White;
            this.dtEndDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.dtEndDay.BorderThickness = 1;
            this.dtEndDay.Checked = true;
            this.dtEndDay.FillColor = System.Drawing.Color.White;
            this.dtEndDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtEndDay.Location = new System.Drawing.Point(12, 463);
            this.dtEndDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtEndDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEndDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEndDay.Name = "dtEndDay";
            this.dtEndDay.Size = new System.Drawing.Size(508, 43);
            this.dtEndDay.TabIndex = 119;
            this.dtEndDay.Value = new System.DateTime(2024, 4, 25, 13, 27, 16, 342);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(13, 416);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 120;
            this.label1.Text = "End day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(13, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 31);
            this.label2.TabIndex = 122;
            this.label2.Text = "Begin day";
            // 
            // dtBeginday
            // 
            this.dtBeginday.BackColor = System.Drawing.Color.White;
            this.dtBeginday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.dtBeginday.BorderThickness = 1;
            this.dtBeginday.Checked = true;
            this.dtBeginday.FillColor = System.Drawing.Color.White;
            this.dtBeginday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtBeginday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtBeginday.Location = new System.Drawing.Point(13, 351);
            this.dtBeginday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtBeginday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtBeginday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtBeginday.Name = "dtBeginday";
            this.dtBeginday.Size = new System.Drawing.Size(508, 43);
            this.dtBeginday.TabIndex = 121;
            this.dtBeginday.Value = new System.DateTime(2024, 4, 25, 13, 27, 16, 342);
            // 
            // btnPost
            // 
            this.btnPost.AutoRoundedCorners = true;
            this.btnPost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPost.BorderRadius = 26;
            this.btnPost.BorderThickness = 1;
            this.btnPost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPost.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnPost.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPost.Location = new System.Drawing.Point(125, 534);
            this.btnPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(280, 55);
            this.btnPost.TabIndex = 123;
            this.btnPost.Text = "Add voucher";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // FAddVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 606);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtBeginday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtEndDay);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblVoucherName);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtVoucherValue);
            this.Controls.Add(this.txtVoucherName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FAddVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAddVoucher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtVoucherValue;
        private Guna.UI2.WinForms.Guna2TextBox txtVoucherName;
        public System.Windows.Forms.Label label;
        public System.Windows.Forms.Label lblVoucherName;
        public System.Windows.Forms.Label lblValue;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtEndDay;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtBeginday;
        private Guna.UI2.WinForms.Guna2Button btnPost;
    }
}