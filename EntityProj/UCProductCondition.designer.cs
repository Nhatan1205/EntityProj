namespace EntityProj.Forms
{
    partial class UCProductCondition
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNextState = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblProductName.Location = new System.Drawing.Point(135, 20);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(164, 31);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "Product Name";
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AutoSize = true;
            this.lblBuyerName.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyerName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBuyerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblBuyerName.Location = new System.Drawing.Point(135, 59);
            this.lblBuyerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(118, 28);
            this.lblBuyerName.TabIndex = 12;
            this.lblBuyerName.Text = "Buyer Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(1085, 21);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(141, 30);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "100.000 VND";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.DarkGray;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(934, 61);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(121, 30);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Completed";
            // 
            // btnNextState
            // 
            this.btnNextState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnNextState.FlatAppearance.BorderSize = 0;
            this.btnNextState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextState.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNextState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnNextState.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNextState.Location = new System.Drawing.Point(1110, 56);
            this.btnNextState.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextState.Name = "btnNextState";
            this.btnNextState.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNextState.Size = new System.Drawing.Size(118, 38);
            this.btnNextState.TabIndex = 15;
            this.btnNextState.Text = "Next state";
            this.btnNextState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextState.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNextState.UseVisualStyleBackColor = false;
            this.btnNextState.MouseEnter += new System.EventHandler(this.btnNextState_MouseEnter);
            this.btnNextState.MouseLeave += new System.EventHandler(this.btnNextState_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // UCProductCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNextState);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblBuyerName);
            this.Controls.Add(this.lblProductName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCProductCondition";
            this.Size = new System.Drawing.Size(1230, 114);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblProductName;
        public System.Windows.Forms.Label lblBuyerName;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Button btnNextState;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}
