namespace EntityProj.Forms
{
    partial class FTrackOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTrackOrder));
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.tcBuyProducts = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpWaitForConfirm = new System.Windows.Forms.TabPage();
            this.tpCompleted = new System.Windows.Forms.TabPage();
            this.containerTop = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnPostProduct = new Guna.UI2.WinForms.Guna2Button();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.containerMenu = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnVoucher = new Guna.UI2.WinForms.Guna2Button();
            this.btnMoney = new Guna.UI2.WinForms.Guna2Button();
            this.btnInformation = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrderAnalysis = new Guna.UI2.WinForms.Guna2Button();
            this.btnSavedProducts = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalesOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnPurchasesOrder = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMenuAccountName = new System.Windows.Forms.Label();
            this.pbMenuAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ratingMenuAccount = new Guna.UI2.WinForms.Guna2RatingStar();
            this.panelTop.SuspendLayout();
            this.tcBuyProducts.SuspendLayout();
            this.containerTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.containerMenu.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(40, 38);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(1907, 21);
            this.bunifuSeparator1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(33, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product List";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.bunifuSeparator1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 70);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1500, 63);
            this.panelTop.TabIndex = 8;
            // 
            // tcBuyProducts
            // 
            this.tcBuyProducts.Controls.Add(this.tpWaitForConfirm);
            this.tcBuyProducts.Controls.Add(this.tpCompleted);
            this.tcBuyProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcBuyProducts.ItemSize = new System.Drawing.Size(250, 50);
            this.tcBuyProducts.Location = new System.Drawing.Point(0, 133);
            this.tcBuyProducts.Margin = new System.Windows.Forms.Padding(4);
            this.tcBuyProducts.Name = "tcBuyProducts";
            this.tcBuyProducts.SelectedIndex = 0;
            this.tcBuyProducts.Size = new System.Drawing.Size(1500, 625);
            this.tcBuyProducts.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcBuyProducts.TabButtonHoverState.FillColor = System.Drawing.Color.White;
            this.tcBuyProducts.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcBuyProducts.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.tcBuyProducts.TabButtonHoverState.InnerColor = System.Drawing.Color.White;
            this.tcBuyProducts.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcBuyProducts.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.tcBuyProducts.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcBuyProducts.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.tcBuyProducts.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.tcBuyProducts.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcBuyProducts.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tcBuyProducts.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcBuyProducts.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.tcBuyProducts.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.tcBuyProducts.TabButtonSize = new System.Drawing.Size(250, 50);
            this.tcBuyProducts.TabIndex = 9;
            this.tcBuyProducts.TabMenuBackColor = System.Drawing.Color.White;
            this.tcBuyProducts.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpWaitForConfirm
            // 
            this.tpWaitForConfirm.BackColor = System.Drawing.Color.White;
            this.tpWaitForConfirm.Location = new System.Drawing.Point(4, 54);
            this.tpWaitForConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.tpWaitForConfirm.Name = "tpWaitForConfirm";
            this.tpWaitForConfirm.Padding = new System.Windows.Forms.Padding(4);
            this.tpWaitForConfirm.Size = new System.Drawing.Size(1492, 567);
            this.tpWaitForConfirm.TabIndex = 0;
            this.tpWaitForConfirm.Text = "Wait for confirmation";
            // 
            // tpCompleted
            // 
            this.tpCompleted.Location = new System.Drawing.Point(4, 54);
            this.tpCompleted.Margin = new System.Windows.Forms.Padding(4);
            this.tpCompleted.Name = "tpCompleted";
            this.tpCompleted.Padding = new System.Windows.Forms.Padding(4);
            this.tpCompleted.Size = new System.Drawing.Size(1492, 567);
            this.tpCompleted.TabIndex = 1;
            this.tpCompleted.Text = "Completed";
            this.tpCompleted.UseVisualStyleBackColor = true;
            // 
            // containerTop
            // 
            this.containerTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.containerTop.Controls.Add(this.btnCart);
            this.containerTop.Controls.Add(this.btnMenu);
            this.containerTop.Controls.Add(this.btnPostProduct);
            this.containerTop.Controls.Add(this.pbLogo);
            this.containerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.containerTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.containerTop.Location = new System.Drawing.Point(0, 0);
            this.containerTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.containerTop.Name = "containerTop";
            this.containerTop.Size = new System.Drawing.Size(1500, 70);
            this.containerTop.TabIndex = 10;
            this.containerTop.Text = "guna2ContainerControl1";
            // 
            // btnCart
            // 
            this.btnCart.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnCart.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnCart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnCart.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnCart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCart.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnCart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCart.Location = new System.Drawing.Point(771, 10);
            this.btnCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCart.Name = "btnCart";
            this.btnCart.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnCart.Size = new System.Drawing.Size(163, 46);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "CART";
            this.btnCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCart.TextOffset = new System.Drawing.Point(7, 0);
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnMenu.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMenu.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnMenu.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMenu.Location = new System.Drawing.Point(1159, 11);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnMenu.Size = new System.Drawing.Size(292, 46);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.TextOffset = new System.Drawing.Point(7, 0);
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnPostProduct
            // 
            this.btnPostProduct.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPostProduct.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnPostProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPostProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPostProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPostProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPostProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPostProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPostProduct.ForeColor = System.Drawing.Color.White;
            this.btnPostProduct.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnPostProduct.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPostProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPostProduct.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnPostProduct.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPostProduct.Location = new System.Drawing.Point(939, 10);
            this.btnPostProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPostProduct.Name = "btnPostProduct";
            this.btnPostProduct.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.btnPostProduct.Size = new System.Drawing.Size(203, 46);
            this.btnPostProduct.TabIndex = 1;
            this.btnPostProduct.Text = "POST NEWS";
            this.btnPostProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPostProduct.TextOffset = new System.Drawing.Point(7, 0);
            this.btnPostProduct.Click += new System.EventHandler(this.btnPostProduct_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.pbLogo.ImageRotate = 0F;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(188, 70);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // containerMenu
            // 
            this.containerMenu.BorderColor = System.Drawing.Color.Black;
            this.containerMenu.Controls.Add(this.btnLogout);
            this.containerMenu.Controls.Add(this.guna2Panel5);
            this.containerMenu.Controls.Add(this.btnVoucher);
            this.containerMenu.Controls.Add(this.btnMoney);
            this.containerMenu.Controls.Add(this.btnInformation);
            this.containerMenu.Controls.Add(this.btnOrderAnalysis);
            this.containerMenu.Controls.Add(this.btnSavedProducts);
            this.containerMenu.Controls.Add(this.guna2Panel6);
            this.containerMenu.Controls.Add(this.btnSalesOrder);
            this.containerMenu.Controls.Add(this.btnPurchasesOrder);
            this.containerMenu.Controls.Add(this.guna2Panel7);
            this.containerMenu.Controls.Add(this.guna2Panel8);
            this.containerMenu.CustomBorderColor = System.Drawing.Color.Black;
            this.containerMenu.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.containerMenu.Location = new System.Drawing.Point(1161, 75);
            this.containerMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.containerMenu.Name = "containerMenu";
            this.containerMenu.Padding = new System.Windows.Forms.Padding(1);
            this.containerMenu.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.containerMenu.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.containerMenu.ShadowDecoration.Enabled = true;
            this.containerMenu.Size = new System.Drawing.Size(292, 651);
            this.containerMenu.TabIndex = 9;
            this.containerMenu.Text = "guna2ContainerControl1";
            // 
            // btnLogout
            // 
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FillColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnLogout.ImageSize = new System.Drawing.Size(34, 34);
            this.btnLogout.Location = new System.Drawing.Point(1, 585);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(290, 55);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.TextOffset = new System.Drawing.Point(10, 0);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.Location = new System.Drawing.Point(1, 569);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(290, 16);
            this.guna2Panel5.TabIndex = 24;
            // 
            // btnVoucher
            // 
            this.btnVoucher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoucher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVoucher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVoucher.FillColor = System.Drawing.Color.White;
            this.btnVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVoucher.ForeColor = System.Drawing.Color.Black;
            this.btnVoucher.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVoucher.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnVoucher.ImageSize = new System.Drawing.Size(34, 34);
            this.btnVoucher.Location = new System.Drawing.Point(1, 514);
            this.btnVoucher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.Size = new System.Drawing.Size(290, 55);
            this.btnVoucher.TabIndex = 28;
            this.btnVoucher.Text = "Voucher";
            this.btnVoucher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVoucher.TextOffset = new System.Drawing.Point(10, 0);
            this.btnVoucher.Click += new System.EventHandler(this.btnVoucher_Click);
            // 
            // btnMoney
            // 
            this.btnMoney.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoney.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMoney.FillColor = System.Drawing.Color.White;
            this.btnMoney.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMoney.ForeColor = System.Drawing.Color.Black;
            this.btnMoney.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMoney.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnMoney.ImageSize = new System.Drawing.Size(34, 34);
            this.btnMoney.Location = new System.Drawing.Point(1, 459);
            this.btnMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(290, 55);
            this.btnMoney.TabIndex = 22;
            this.btnMoney.Text = "Recharge/Withdraw money";
            this.btnMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMoney.TextOffset = new System.Drawing.Point(10, 0);
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInformation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInformation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInformation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformation.FillColor = System.Drawing.Color.White;
            this.btnInformation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInformation.ForeColor = System.Drawing.Color.Black;
            this.btnInformation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInformation.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnInformation.ImageSize = new System.Drawing.Size(34, 34);
            this.btnInformation.Location = new System.Drawing.Point(1, 404);
            this.btnInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(290, 55);
            this.btnInformation.TabIndex = 21;
            this.btnInformation.Text = "Profile";
            this.btnInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInformation.TextOffset = new System.Drawing.Point(10, 0);
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnOrderAnalysis
            // 
            this.btnOrderAnalysis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderAnalysis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderAnalysis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrderAnalysis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrderAnalysis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderAnalysis.FillColor = System.Drawing.Color.White;
            this.btnOrderAnalysis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrderAnalysis.ForeColor = System.Drawing.Color.Black;
            this.btnOrderAnalysis.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrderAnalysis.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnOrderAnalysis.ImageSize = new System.Drawing.Size(34, 34);
            this.btnOrderAnalysis.Location = new System.Drawing.Point(1, 349);
            this.btnOrderAnalysis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderAnalysis.Name = "btnOrderAnalysis";
            this.btnOrderAnalysis.Size = new System.Drawing.Size(290, 55);
            this.btnOrderAnalysis.TabIndex = 20;
            this.btnOrderAnalysis.Text = "Order Analysis";
            this.btnOrderAnalysis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrderAnalysis.TextOffset = new System.Drawing.Point(10, 0);
            this.btnOrderAnalysis.Click += new System.EventHandler(this.btnOrderAnalysis_Click);
            // 
            // btnSavedProducts
            // 
            this.btnSavedProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSavedProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSavedProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSavedProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSavedProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSavedProducts.FillColor = System.Drawing.Color.White;
            this.btnSavedProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSavedProducts.ForeColor = System.Drawing.Color.Black;
            this.btnSavedProducts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSavedProducts.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnSavedProducts.ImageSize = new System.Drawing.Size(34, 34);
            this.btnSavedProducts.Location = new System.Drawing.Point(1, 294);
            this.btnSavedProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavedProducts.Name = "btnSavedProducts";
            this.btnSavedProducts.Size = new System.Drawing.Size(290, 55);
            this.btnSavedProducts.TabIndex = 19;
            this.btnSavedProducts.Text = "Saved Products";
            this.btnSavedProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSavedProducts.TextOffset = new System.Drawing.Point(10, 0);
            this.btnSavedProducts.Click += new System.EventHandler(this.btnSavedProducts_Click);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel6.Controls.Add(this.label4);
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel6.Location = new System.Drawing.Point(1, 247);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(290, 47);
            this.guna2Panel6.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label4.Location = new System.Drawing.Point(19, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Features";
            // 
            // btnSalesOrder
            // 
            this.btnSalesOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalesOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalesOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalesOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalesOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesOrder.FillColor = System.Drawing.Color.White;
            this.btnSalesOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalesOrder.ForeColor = System.Drawing.Color.Black;
            this.btnSalesOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalesOrder.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnSalesOrder.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSalesOrder.Location = new System.Drawing.Point(1, 192);
            this.btnSalesOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalesOrder.Name = "btnSalesOrder";
            this.btnSalesOrder.Size = new System.Drawing.Size(290, 55);
            this.btnSalesOrder.TabIndex = 17;
            this.btnSalesOrder.Text = "Sales Order";
            this.btnSalesOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalesOrder.TextOffset = new System.Drawing.Point(10, 0);
            this.btnSalesOrder.Click += new System.EventHandler(this.btnSalesOrder_Click);
            // 
            // btnPurchasesOrder
            // 
            this.btnPurchasesOrder.CustomBorderColor = System.Drawing.Color.White;
            this.btnPurchasesOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchasesOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchasesOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurchasesOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPurchasesOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchasesOrder.FillColor = System.Drawing.Color.White;
            this.btnPurchasesOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPurchasesOrder.ForeColor = System.Drawing.Color.Black;
            this.btnPurchasesOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPurchasesOrder.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnPurchasesOrder.ImageSize = new System.Drawing.Size(34, 34);
            this.btnPurchasesOrder.Location = new System.Drawing.Point(1, 137);
            this.btnPurchasesOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPurchasesOrder.Name = "btnPurchasesOrder";
            this.btnPurchasesOrder.Size = new System.Drawing.Size(290, 55);
            this.btnPurchasesOrder.TabIndex = 16;
            this.btnPurchasesOrder.Text = "Purchase order";
            this.btnPurchasesOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPurchasesOrder.TextOffset = new System.Drawing.Point(10, 0);
            this.btnPurchasesOrder.Click += new System.EventHandler(this.btnPurchasesOrder_Click);
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel7.Controls.Add(this.label5);
            this.guna2Panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel7.Location = new System.Drawing.Point(1, 91);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(290, 46);
            this.guna2Panel7.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.label5.Location = new System.Drawing.Point(19, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Order Management";
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.Controls.Add(this.lblMenuAccountName);
            this.guna2Panel8.Controls.Add(this.pbMenuAvatar);
            this.guna2Panel8.Controls.Add(this.ratingMenuAccount);
            this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel8.Location = new System.Drawing.Point(1, 1);
            this.guna2Panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(290, 90);
            this.guna2Panel8.TabIndex = 14;
            // 
            // lblMenuAccountName
            // 
            this.lblMenuAccountName.AutoSize = true;
            this.lblMenuAccountName.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblMenuAccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(132)))));
            this.lblMenuAccountName.Location = new System.Drawing.Point(99, 9);
            this.lblMenuAccountName.Name = "lblMenuAccountName";
            this.lblMenuAccountName.Size = new System.Drawing.Size(156, 30);
            this.lblMenuAccountName.TabIndex = 3;
            this.lblMenuAccountName.Text = "Account name";
            // 
            // pbMenuAvatar
            // 
            this.pbMenuAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbMenuAvatar.ImageRotate = 0F;
            this.pbMenuAvatar.Location = new System.Drawing.Point(0, 0);
            this.pbMenuAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMenuAvatar.Name = "pbMenuAvatar";
            this.pbMenuAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbMenuAvatar.Size = new System.Drawing.Size(91, 90);
            this.pbMenuAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenuAvatar.TabIndex = 0;
            this.pbMenuAvatar.TabStop = false;
            // 
            // ratingMenuAccount
            // 
            this.ratingMenuAccount.Location = new System.Drawing.Point(103, 44);
            this.ratingMenuAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ratingMenuAccount.Name = "ratingMenuAccount";
            this.ratingMenuAccount.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.ratingMenuAccount.ReadOnly = true;
            this.ratingMenuAccount.Size = new System.Drawing.Size(149, 36);
            this.ratingMenuAccount.TabIndex = 2;
            // 
            // FTrackOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1500, 780);
            this.Controls.Add(this.containerMenu);
            this.Controls.Add(this.tcBuyProducts);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.containerTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FTrackOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTrackOrder";
            this.Load += new System.EventHandler(this.FTrackOrder_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tcBuyProducts.ResumeLayout(false);
            this.containerTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.containerMenu.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2TabControl tcBuyProducts;
        private System.Windows.Forms.TabPage tpWaitForConfirm;
        private System.Windows.Forms.TabPage tpCompleted;
        private Guna.UI2.WinForms.Guna2ContainerControl containerTop;
        private Guna.UI2.WinForms.Guna2Button btnCart;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2Button btnPostProduct;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2ContainerControl containerMenu;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Button btnMoney;
        private Guna.UI2.WinForms.Guna2Button btnInformation;
        private Guna.UI2.WinForms.Guna2Button btnOrderAnalysis;
        private Guna.UI2.WinForms.Guna2Button btnSavedProducts;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnSalesOrder;
        private Guna.UI2.WinForms.Guna2Button btnPurchasesOrder;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private System.Windows.Forms.Label lblMenuAccountName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbMenuAvatar;
        private Guna.UI2.WinForms.Guna2RatingStar ratingMenuAccount;
        private Guna.UI2.WinForms.Guna2Button btnVoucher;
    }
}