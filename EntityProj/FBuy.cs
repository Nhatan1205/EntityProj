using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using EntityProj.Properties;

namespace EntityProj.Forms
{
    public partial class FBuy : Form
    {
        private ProductDAO productDAO = new ProductDAO();
        private Account account = new Account();
        //private RecommendDAO recommendDAO = new RecommendDAO();
        private bool save;


        public FBuy()
        {
            InitializeComponent();
            containerMenu.Visible = false;
            save = false;
        }

        public FBuy(Account acc)
        {
            InitializeComponent();
            containerMenu.Visible = false;
            account = acc;
            save = false;
        }

        private void ucProduct2_Load(object sender, EventArgs e)
        {

        }

        private void FBuy_Load(object sender, EventArgs e)
        {
            //delete all user controls
            //for (int i = flpProduct.Controls.Count - 1; i >= 0; i--)
            //{
            //    Control control = flpProduct.Controls[i];
            //    if (control is UCProduct)  
            //    {
            //        flpRecommendProducts.Controls.Remove(control);
            //        control.Dispose();  
            //    }
            //}
            //for (int i = flpRecommendProducts.Controls.Count - 1; i >= 0; i--)
            //{
            //    Control control = flpRecommendProducts.Controls[i];
            //    if (control is UCProduct)  
            //    {
            //        flpRecommendProducts.Controls.Remove(control);
            //        control.Dispose(); 
            //    }
            //}
            ////add product list
            //List<Product> products = productDAO.LoadList();
            //foreach (var pd in products)
            //{
            //    if (pd.BuyerID <= 0 && pd.OrderCondition <= (int)ordercondition.Displaying)
            //    {
            //        UCProduct uc = new UCProduct(pd, account);
            //        uc.ProductDoubleClick += UCProduct_ProductDoubleClick;
            //        flpProduct.Controls.Add(uc);
            //    }
            //}
            //lblMenuAccountName.Text = account.Name;
            //ratingMenuAccount.Value = account.AvgRating;
            //lblProducts.Text = "All products";
            //convertByte(pbMenuAvatar, account.Avatar);
            ////add recommend list
            //List<string> types = recommendDAO.GetTopThreeRecommendedTypesByBuyerID(account.Id);
            //List<Product> recommendedProducts = new List<Product>();
            //foreach (string type in types)
            //{
            //    List<Product> productsByType = productDAO.LoadRecommendList(type);
            //    // Add the top 3 products for this type to the recommended products list
            //    recommendedProducts.AddRange(productsByType); 
            //}


            //foreach (var pd in recommendedProducts)
            //{
            //    if (pd.BuyerID <= 0 && pd.OrderCondition <= (int)ordercondition.Displaying)
            //    {
            //        UCProduct uc = new UCProduct(pd, account);
            //        uc.ProductDoubleClick += UCProduct_ProductDoubleClick;
            //        flpRecommendProducts.Controls.Add(uc);
            //    }
            //}
            //if (flpRecommendProducts.Controls.Count <= 0)
            //{
            //    flpRecommendProducts.Visible = false;
            //    panelRecommendProducts.Visible = false;
            //    panelRecommend.Visible = false;
            //}
            //else
            //{
            //    flpRecommendProducts.Visible = true;
            //    panelRecommendProducts.Visible = true;
            //    panelRecommend.Visible = true;
            //    adjustRecommendFlowLayoutPanel();
            //}
        }

        // Event handler for UCProduct's ProductDoubleClick event
        private void UCProduct_ProductDoubleClick(object sender, EventArgs e)
        {
            //// Hide the current form (FBuy)
            //this.Hide();
            //// Open the FBuyDetail form
            //FBuyDetail fBuyDetail = new FBuyDetail((sender as UCProduct).Product, account);
            //fBuyDetail.Closed += (s, args) => this.Close();
            //fBuyDetail.Show();
        }


        private void adjustRecommendFlowLayoutPanel()
        {
            // Disable vertical scroll
            flpRecommendProducts.AutoScroll = true;
            flpRecommendProducts.WrapContents = false;
            panelRecommendProducts.AutoScroll = true;
            panelRecommendProducts.HorizontalScroll.Visible = true;
            // Calculate and set the width of flpRecommendProducts based on the sum of widths of child controls
            int totalWidth = 0;
            foreach (Control control in flpRecommendProducts.Controls)
            {
                totalWidth += control.Width;
            }
            flpRecommendProducts.Width = totalWidth;
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
                        pic.Image = System.Drawing.Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }
        }


        private void txtMaxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, không cho phép nhập
                e.Handled = true;
            }
        }

        private void txtMinPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, không cho phép nhập
                e.Handled = true;
            }
        }


        private void ddCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (ddCategories.SelectedItem != null)
            {
                selectedValue = ddCategories.SelectedItem.ToString();
            }
            getFilter();
            */
        }
   
        private void btnLoad_Click(object sender, EventArgs e)
        {
            FBuy_Load(sender, e);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //List<Product> products = productDAO.LoadList();
            //List<Product> productWithoutBuyerAndDisplaying = new List<Product>();
            ////get product without buyid and having condition displaying
            //foreach (var pd in products)
            //{
            //    if ((pd.BuyerID == null || pd.BuyerID <= 0) && pd.OrderCondition == (int)ordercondition.Displaying)
            //    {
            //        productWithoutBuyerAndDisplaying.Add(pd);
            //    }
            //}
            //string productName = txtProductName.Text;
            //string brand = txtBrand.Text;
            //double maxPrice = double.TryParse(txtMaxPrice.Text, out double parsedMaxPrice) ? parsedMaxPrice : double.MaxValue;
            //double minPrice = double.TryParse(txtMinPrice.Text, out double parsedMinPrice) ? parsedMinPrice : double.MinValue;
            //string selectedCategory = ddCategories.SelectedItem?.ToString();

            //// Filter products based on the specified conditions
            //List<Product> filteredProducts = productWithoutBuyerAndDisplaying.Where(pd =>
            //    (string.IsNullOrEmpty(productName) || pd.Name.ToLower().Contains(productName.ToLower())) &&
            //    (string.IsNullOrEmpty(brand) || pd.Brand.ToLower().Contains(brand.ToLower())) &&
            //    (pd.SalePrice >= minPrice && pd.SalePrice <= maxPrice) &&
            //    (string.IsNullOrEmpty(selectedCategory) || pd.Category == selectedCategory)
            //).ToList();

            //// Clear existing products in the flow layout panel
            //for (int i = flpProduct.Controls.Count - 1; i >= 0; i--)
            //{
            //    Control control = flpProduct.Controls[i];
            //    if (control is UCProduct)
            //    {
            //        flpRecommendProducts.Controls.Remove(control);
            //        control.Dispose();
            //    }
            //}

            //// Add filtered products to the flow layout panel
            //foreach (var pd in filteredProducts)
            //{
            //    UCProduct uc = new UCProduct(pd, account);
            //    uc.ProductDoubleClick += UCProduct_ProductDoubleClick;
            //    flpProduct.Controls.Add(uc);
            //}
            ////
            //flpRecommendProducts.Visible = false;
            //panelRecommendProducts.Visible = false;
            //panelRecommend.Visible = false;
            //lblProducts.Text = "Filtered products";
        }


        private void btnCart_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FCart f = new FCart(account);
            //f.Closed += (s, args) => this.Close();
            //f.Show();
        }

        private void btnPostProduct_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FSellDetail f = new FSellDetail(account);
            //f.Closed += (s, args) => this.Close();
            //f.Show();
        }

        private void btnPurchasesOrder_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FTrackOrder f = new FTrackOrder(account);
            //f.Closed += (s, args) => this.Close();
            //f.Show();
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FProductManagement f = new FProductManagement(account);
            //f.Closed += (s, args) => this.Close();
            //f.Show();
        }

        private void btnSavedProducts_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FSaveList f = new FSaveList(account);
            //f.Closed += (s, args) => this.Close();
            //f.Show();
        }

        private void btnOrderAnalysis_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FOrderAnalysis f = new FOrderAnalysis(account);
            //f.Closed += (s, args) => this.Close();
            //f.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FInformation f = new FInformation(account);
            //f.Closed += (s, args) => this.Close();
            //f.Show();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FMoney f = new FMoney(account);
            //f.Closed += (s, args) => this.Close();
            //f.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FSignin f = new FSignin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            FBuy_Load(sender, e);
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

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FVoucher f = new FVoucher(account);
            //f.Closed += (s, args) => this.Close();
            //f.Show();
        }
    }
}
