namespace EntityProj.Forms
{
    partial class UCReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCReview));
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBorder = new Guna.UI2.WinForms.Guna2Panel();
            this.ucProductConditionReduce = new EntityProj.Forms.UCProductCondition();
            this.rsStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.panelRating = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblStar = new System.Windows.Forms.Label();
            this.lblNameSeller = new System.Windows.Forms.Label();
            this.pbAvtSeller = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panelBody.SuspendLayout();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvtSeller)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelBorder);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(6);
            this.panelBody.Size = new System.Drawing.Size(1480, 283);
            this.panelBody.TabIndex = 0;
            // 
            // panelBorder
            // 
            this.panelBorder.BorderColor = System.Drawing.Color.Black;
            this.panelBorder.BorderRadius = 10;
            this.panelBorder.BorderThickness = 1;
            this.panelBorder.Controls.Add(this.rsStar);
            this.panelBorder.Controls.Add(this.panelRating);
            this.panelBorder.Controls.Add(this.lblStar);
            this.panelBorder.Controls.Add(this.lblNameSeller);
            this.panelBorder.Controls.Add(this.pbAvtSeller);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.Location = new System.Drawing.Point(6, 6);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(1468, 271);
            this.panelBorder.TabIndex = 0;
            // 
            // ucProductConditionReduce
            // 
            this.ucProductConditionReduce.BackColor = System.Drawing.Color.Gainsboro;
            this.ucProductConditionReduce.Location = new System.Drawing.Point(14, 159);
            this.ucProductConditionReduce.Margin = new System.Windows.Forms.Padding(2);
            this.ucProductConditionReduce.Name = "ucProductConditionReduce";
            this.ucProductConditionReduce.Size = new System.Drawing.Size(1441, 96);
            this.ucProductConditionReduce.TabIndex = 13;
            // 
            // rsStar
            // 
            this.rsStar.FillColor = System.Drawing.Color.Transparent;
            this.rsStar.Location = new System.Drawing.Point(173, 106);
            this.rsStar.Name = "rsStar";
            this.rsStar.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.rsStar.Size = new System.Drawing.Size(193, 38);
            this.rsStar.TabIndex = 12;
            // 
            // panelRating
            // 
            this.panelRating.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelRating.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRating.BackgroundImage")));
            this.panelRating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRating.BorderColor = System.Drawing.Color.Transparent;
            this.panelRating.BorderRadius = 3;
            this.panelRating.BorderThickness = 1;
            this.panelRating.Location = new System.Drawing.Point(107, 52);
            this.panelRating.Name = "panelRating";
            this.panelRating.ShowBorders = true;
            this.panelRating.Size = new System.Drawing.Size(1348, 45);
            this.panelRating.TabIndex = 11;
            // 
            // lblStar
            // 
            this.lblStar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblStar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblStar.Location = new System.Drawing.Point(110, 109);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(57, 33);
            this.lblStar.TabIndex = 9;
            this.lblStar.Text = "5";
            // 
            // lblNameSeller
            // 
            this.lblNameSeller.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblNameSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblNameSeller.Location = new System.Drawing.Point(107, 15);
            this.lblNameSeller.Name = "lblNameSeller";
            this.lblNameSeller.Size = new System.Drawing.Size(878, 33);
            this.lblNameSeller.TabIndex = 10;
            this.lblNameSeller.Text = "Andrew NG";
            // 
            // pbAvtSeller
            // 
            this.pbAvtSeller.AllowFocused = false;
            this.pbAvtSeller.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAvtSeller.AutoSizeHeight = true;
            this.pbAvtSeller.BorderRadius = 35;
            this.pbAvtSeller.Image = ((System.Drawing.Image)(resources.GetObject("pbAvtSeller.Image")));
            this.pbAvtSeller.IsCircle = true;
            this.pbAvtSeller.Location = new System.Drawing.Point(26, 20);
            this.pbAvtSeller.Name = "pbAvtSeller";
            this.pbAvtSeller.Size = new System.Drawing.Size(70, 70);
            this.pbAvtSeller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvtSeller.TabIndex = 8;
            this.pbAvtSeller.TabStop = false;
            this.pbAvtSeller.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // UCReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBody);
            this.Name = "UCReview";
            this.Size = new System.Drawing.Size(1480, 283);
            this.Load += new System.EventHandler(this.UCReview_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvtSeller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private Guna.UI2.WinForms.Guna2Panel panelBorder;
        private UCProductCondition ucProductConditionReduce;
        private Guna.UI2.WinForms.Guna2RatingStar rsStar;
        private Bunifu.UI.WinForms.BunifuPanel panelRating;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Label lblNameSeller;
        private Bunifu.UI.WinForms.BunifuPictureBox pbAvtSeller;
    }
}
