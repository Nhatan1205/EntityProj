using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProj.Forms
{
    public partial class FBuyDetail : Form
    {
        private ImageDAO imageDAO = new ImageDAO();
        private ProductDAO productDAO = new ProductDAO();
        private FavoriteDAO favoriteDAO = new FavoriteDAO();
        private CartDAO cartDAO = new CartDAO();
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private Product product = new Product();


        public FBuyDetail()
        {
            InitializeComponent();
            containerMenu.Visible = false;
        }

        public FBuyDetail(Product pd,Account acc)
        {
            InitializeComponent();
            containerMenu.Visible = false;
            account = acc;
            product = pd;
            product.ViewCount++;
            productDAO.Update(product);
        }

        private void convertByte(PictureBox pic, byte[] imageData)
        {

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Attempt to create Image object
                    try
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (favoriteDAO.checkProductinFavorite(account.ID, product.ID))
            {
                favoriteDAO.delete(account.ID, product.ID);
                btnSave.Text = "Save";

                btnSave.FillColor = Color.Red;
                btnSave.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                favoriteDAO.add(account.ID, product.ID);
                btnSave.Text = "Saved";

                btnSave.FillColor = Color.WhiteSmoke;
                btnSave.ForeColor = Color.Red;
            }
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (cartDAO.checkProductinCart(account.ID, product.ID))
            {
                cartDAO.delete(account.ID, product.ID);
                btnAddtoCart.Text = "Add to cart";
            }
            else
            {
                cartDAO.add(account.ID, product.ID);
                btnAddtoCart.Text = "Already in your cart";
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCart f = new FCart(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnPostProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSellDetail f = new FSellDetail(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (containerMenu.Visible == false)
            {
                containerMenu.Visible = true;
            }
            else
            {
                containerMenu.Visible = false;
            }
        }

        private void btnPurchasesOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FTrackOrder f = new FTrackOrder(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FProductManagement f = new FProductManagement(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSavedProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSaveList f = new FSaveList(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnOrderAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FOrderAnalysis f = new FOrderAnalysis(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FInformation f = new FInformation(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMoney f = new FMoney(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignin f = new FSignin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void SetRichTextBoxHeight(RichTextBox richTextBox)
        {
            int lineCount = richTextBox.GetLineFromCharIndex(richTextBox.TextLength) + 1;
            int lineHeight = richTextBox.Font.Height;
            int newHeight = lineHeight * lineCount + 10;
            richTextBox.Height = newHeight;
        }

        private void FBuyDetail_Load(object sender, EventArgs e)
        {
            product.ViewCount++;
            productDAO.Update(product);
            lblProductName.Text = product.Name;
            lblSellPrice.Text = product.SalePrice.ToString("N0") + " VND";
            lblBuyPrice.Text = product.OriginalPrice.ToString("N0") + " VND";
            txtStatus.Text = product.Status.ToString();
            txtDescription.Text = product.Description.ToString();
            txtSupportPolicy.Text = product.SupportPolicy.ToString();
            txtFunctionalities.Text = product.Functionality.ToString();
            SetRichTextBoxHeight(txtStatus);
            panelStatus.Height = txtStatus.Height;
            SetRichTextBoxHeight(txtDescription);
            panelDescription.Height = txtDescription.Height;
            SetRichTextBoxHeight(txtFunctionalities);
            panelFunctionality.Height = txtFunctionalities.Height + 30;
            lblArea.Text = "Area: " + product.Area;
            lblOrigin.Text = "Origin: " + product.Origin;
            lblMaterial.Text = "Material: " + product.Material;
            lblSize.Text = "Size: " + product.Size;
            lblCondition.Text = "Condition: " + product.Condition + "%";
            lblBrand.Text = "Brand: " + product.Brand;
            lblCategory.Text = "Category: " + product.Category;
            lblType.Text = "Type: " + product.Type;
            lblCancelHour.Text = product.CancelLimit + " h";
            lblCancel.Text = (bool)product.CancelRefund ? "Get refunded for cancellations." : "No refund for cancellations.";
            lblPostingTime.Text = (product.PostedTime.Value.Date == DateTime.Now.Date) ? ((DateTime.Now.Hour - product.PostedTime.Value.Hour) + " hours ago") : product.PostedTime.Value.ToString("dd-MM-yyyy");
            GetImageProduct();

            //check button save
            if (favoriteDAO.checkProductinFavorite(account.ID, product.ID))
            {
                btnSave.Text = "Saved";
                btnSave.FillColor = Color.WhiteSmoke;
                btnSave.ForeColor = Color.Red;
            }
            else
            {
                btnSave.Text = "Save";
                btnSave.FillColor = Color.Red;
                btnSave.ForeColor = Color.WhiteSmoke;
            }
            //check cart
            if (cartDAO.checkProductinCart(account.ID, product.ID))
            {
                btnAddtoCart.Text = "Already in your cart";
            }
            else
            {
                btnAddtoCart.Text = "Add to cart";
            }
            //check seller
            if (account.ID == product.SellerID)
            {
                btnSave.Visible = false;
                btnBuy.Visible = false;
                btnAddtoCart.Visible = false;
            }

            Account seller = accountDAO.Retrieve(product.SellerID.Value);



            lblAvatarName.Text = seller.Name;
            AccountExtension sellerE = new AccountExtension(seller.ID);
            ratingSeller.Value = sellerE.AvgRating;

            convertByte(pbAvatar, seller.Avatar);
            // menu
            lblMenuAccountName.Text = account.Name;
            AccountExtension accE = new AccountExtension(account.ID);
            ratingMenuAccount.Value = accE.AvgRating;
            convertByte(pbMenuAvatar, account.Avatar);

            //relate products
            List<Product> relatedProducts = productDAO.LoadSimilarProducts(product.ID, product.Type);
            if (relatedProducts.Count > 0)
            {
                panelRelatedProducts.Visible = true;
                lblRelatedProducts.Visible = true;
                foreach (var pd in relatedProducts)
                {
                    if (pd.BuyerID <= 0 && pd.OrderCondition <= (int)ordercondition.Displaying)
                    {
                        UCProduct uc = new UCProduct(pd, account);
                        uc.ProductDoubleClick += UCProduct_ProductDoubleClick;
                        flpRelatedProducts.Controls.Add(uc);
                    }
                }
                adjustRecommendFlowLayoutPanel();
            }
            else
            {
                panelRelatedProducts.Visible = false;
                lblRelatedProducts.Visible = false;
            }

        }

        private void adjustRecommendFlowLayoutPanel()
        {
            // Disable vertical scroll
            flpRelatedProducts.AutoScroll = true;
            flpRelatedProducts.WrapContents = false;
            panelRelatedProducts.AutoScroll = true;
            panelRelatedProducts.HorizontalScroll.Visible = true;
            // Calculate and set the width of flpRecommendProducts based on the sum of widths of child controls
            int totalWidth = 0;
            foreach (Control control in flpRelatedProducts.Controls)
            {
                totalWidth += control.Width;
            }
            flpRelatedProducts.Width = totalWidth;
        }

        private void GetImageProduct()
        {
            DataTable ImageTable = (DataTable)imageDAO.GetImageProduct(product.ID);
            int pictureBoxIndex = 0;
            foreach (DataRow row in ImageTable.Rows)
            {
                if (pictureBoxIndex >= 4) // If we have more images than PictureBoxes
                    break;

                byte[] imageData = (byte[])row["Image"]; // Access the "Image" column

                // Load image into PictureBox
                MemoryStream ms = new MemoryStream(imageData);

                // Assign pictureBox variable based on index
                if (pictureBoxIndex == 0)
                {
                    // For the first image, assign to btnImage1
                    btnImage1.Image = Image.FromStream(ms);
                    btnImage1.Visible = true;
                }
                else
                {
                    // For the rest of the images, assign to Guna2ImageButton controls
                    Guna2PictureBox pictureBox = null;
                    switch (pictureBoxIndex)
                    {
                        case 1:
                            pictureBox = btnImage2;
                            break;
                        case 2:
                            pictureBox = btnImage3;
                            break;
                        case 3:
                            pictureBox = btnImage4;
                            break;
                    }
                    if (pictureBox != null)
                    {
                        pictureBox.Image = Image.FromStream(ms);
                        pictureBox.Visible = true;
                    }
                }

                pictureBoxIndex++;
            }
            // Hide any remaining PictureBoxes
            for (int i = pictureBoxIndex; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        btnImage1.Visible = false;
                        break;
                    case 1:
                        btnImage2.Visible = false;
                        break;
                    case 2:
                        btnImage3.Visible = false;
                        break;
                    case 3:
                        btnImage4.Visible = false;
                        break;
                }
            }
        }



        private void pbLogo_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FBuy f = new FBuy(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            List<Product> products = new List<Product>
                {
                    product
                };
            FDelivery f = new FDelivery(account, products);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }


        // Event handler for UCProduct's ProductDoubleClick event
        private void UCProduct_ProductDoubleClick(object sender, EventArgs e)
        {
            // Hide the current form (FBuy)
            this.Hide();
            // Open the FBuyDetail form
            FBuyDetail fBuyDetail = new FBuyDetail((sender as UCProduct).Product, account);
            fBuyDetail.Closed += (s, args) => this.Close();
            fBuyDetail.Show();
        }

        private void lblAvatarName_Click(object sender, EventArgs e)
        {
            FReview fReview = new FReview(account, product);
            fReview.Show();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            this.Hide();
            FVoucher f = new FVoucher(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnImage2_Click(object sender, EventArgs e)
        {
            Guna2PictureBox temp = new Guna2PictureBox();
            temp.Image = btnImage1.Image;
            btnImage1.Image = btnImage2.Image;
            btnImage2.Image = temp.Image;
        }

        private void btnImage3_Click(object sender, EventArgs e)
        {
            Guna2PictureBox temp = new Guna2PictureBox();
            temp.Image = btnImage1.Image;
            btnImage1.Image = btnImage3.Image;
            btnImage3.Image = temp.Image;
        }

        private void btnImage4_Click(object sender, EventArgs e)
        {
            Guna2PictureBox temp = new Guna2PictureBox();
            temp.Image = btnImage1.Image;
            btnImage1.Image = btnImage4.Image;
            btnImage4.Image = temp.Image;
        }
    }
}
