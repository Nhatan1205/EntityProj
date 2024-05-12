using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityProj.Properties;

namespace EntityProj.Forms
{
    public partial class FSellDetail : Form
    {
        private ProductDAO productDAO = new ProductDAO();
        private ImageDAO imageDAO = new ImageDAO();
        private Account acc = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private ShippingDAO shippingDAO = new ShippingDAO();
        private string selectedCategory = null;
        private string selectedArea = null;
        private bool edit = false;
        private Product pd;

        public FSellDetail()
        {
            InitializeComponent();
            SetNullButtonImage();
        }

        public FSellDetail(Product pd, Account acc)
        {
            InitializeComponent();
            SetNullButtonImage();
            this.pd = pd;
            this.acc = acc;
            edit = true;
            GetImageProduct();
            Initialize();
            HideCompleteDetail();
        }

        public FSellDetail(Product pd, Account acc, bool check)
        {
            InitializeComponent();
            SetNullButtonImage();
            this.pd = pd;
            this.acc = acc; 
            Initialize();
            GetImageProduct();
        }

        public FSellDetail(Account acc)
        {
            InitializeComponent();
            SetNullButtonImage();
            HideCompleteDetail();
            this.acc = acc;     
        }

        public void SetNullButtonImage()
        {
            btnImage1.Image = null;
            btnImage2.Image = null;
            btnImage3.Image = null;
            btnImage4.Image = null;
        }

        public void HideCompleteDetail()
        {
            lblDeliveryInformation.Visible = false;
            gbBillStatus.Visible = false;
            containerMenu.Visible = false;
            lblCompleteTime.Visible = false;
            lblTime.Visible = false;
            lblBuyerName.Visible = false;
            lblPhone.Visible = false;
            txtAddress.Visible = false;
        }

        public void Initialize()
        {
            containerMenu.Visible = false; 
            if (pd.CompleteTime.Year < 2024)
            {
                lblCompleteTime.Visible = false;
                lblTime.Visible = false;
            } else
            {
                lblCompleteTime.Text = pd.CompleteTime.ToString("dd-MM-yyyy");
            }
            selectedCategory = pd.Category;
            txtProductTitle.Text = pd.Name;
            txtType.Text = pd.Type;
            txtBuyPrice.Text = pd.OriginalPrice.ToString();
            txtSellPrice.Text = pd.SalePrice.ToString();
            selectedArea = pd.Area;
            txtCondition.Text = pd.Condition;
            txtStatus.Text = pd.Status;
            txtSupportPolicy.Text = pd.SupportPolicy;
            txtBrand.Text = pd.Brand;
            txtOrigin.Text = pd.Origin;
            txtMaterial.Text = pd.Material;
            txtSize.Text = pd.Size;
            txtFunctionalities.Text = pd.Functionality;
            txtDescription.Text = pd.Description;
            btnPost.Text = "Update product";
            cbCategory.SelectedItem = pd.Category;
            cbArea.SelectedItem = pd.Area;
            //shipping info
            Shipping shipping = shippingDAO.GetShipping(pd.SelectedShipping);
            if(shipping!=null)
            {
                lblBuyerName.Text = shipping.RecipientName;
                lblPhone.Text = shipping.PhoneNo;
                txtAddress.Text = shipping.Address;
            }
            //
            txtCancelTime.Text = pd.CancelLimit.ToString();
            cbCancel.Checked = pd.CancelRefund;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenImageDialog(Guna.UI2.WinForms.Guna2ImageButton button)
        {
            if (button.Image != null)
            {
                button.Image = null;
            } else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All files(*.*)|*.*|png files(*.png)|*.png|jpg files(*.jpg)|*.jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    button.Image = System.Drawing.Image.FromFile(dialog.FileName);
                }
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double StringToDouble(string str)
        {
            double decimalResult;
            if (double.TryParse(str, out decimalResult))
            {
                    return (double)decimalResult;
            }
            MessageBox.Show("The value of price is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaterial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrigin_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSellPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuyPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCondition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupportPolicy_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelMiddle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImage1_Click_1(object sender, EventArgs e)
        {
            OpenImageDialog(btnImage1);
        }

        private void btnImage2_Click_1(object sender, EventArgs e)
        {
            OpenImageDialog(btnImage2);
        }

        private void btnImage3_Click_1(object sender, EventArgs e)
        {
            OpenImageDialog(btnImage3);
        }

        private void btnImage4_Click_1(object sender, EventArgs e)
        {
            OpenImageDialog(btnImage4);
        }


        public bool IsTextBoxEmpty( Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text);
        }

        public bool checkNull()
        {
            if (IsTextBoxEmpty(txtProductTitle)) return false;
            if (IsTextBoxEmpty(txtType)) return false;
            if (IsTextBoxEmpty(txtBuyPrice)) return false;
            if (IsTextBoxEmpty(txtSellPrice)) return false;
            if (IsTextBoxEmpty(txtCondition)) return false;
            if (IsTextBoxEmpty(txtStatus)) return false;
            if (IsTextBoxEmpty(txtSupportPolicy)) return false;
            if (IsTextBoxEmpty(txtBrand)) return false;
            if (IsTextBoxEmpty(txtOrigin)) return false;
            if (IsTextBoxEmpty(txtMaterial)) return false;
            if (IsTextBoxEmpty(txtMaterial)) return false;
            if (IsTextBoxEmpty(txtSize)) return false;
            if (IsTextBoxEmpty(txtFunctionalities)) return false;
            if(cbArea.SelectedIndex == 0) return false;
            if (cbCategory.SelectedIndex == 0) return false;
            if (btnImage1.Image == null && btnImage2.Image == null && btnImage3.Image == null && btnImage4.Image == null) return false;
            return true;
        }

        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Save the image to the memory stream in PNG format
                image.Save(ms, ImageFormat.Png);

                // Return the byte array representation of the image
                return ms.ToArray();
            }
        }

        private void btnPost_Click_1(object sender, EventArgs e)
        {
            if(!checkNull())
            {
                MessageBox.Show("Please fill in all required information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //string category = ddCategories.SelectedValue.ToString();
            Product product = new Product(selectedCategory, txtProductTitle.Text, txtType.Text, StringToDouble(txtBuyPrice.Text), StringToDouble(txtSellPrice.Text), selectedArea, txtCondition.Text, txtStatus.Text, txtSupportPolicy.Text, txtBrand.Text, txtOrigin.Text, txtMaterial.Text, txtSize.Text, txtFunctionalities.Text, txtDescription.Text, txtCancelTime.Text, cbCancel.Checked, acc.Id);
            if (!edit)
            {
                product.PostedTime = DateTime.Now;
                productDAO.Add(product);
                //Add images to Productimages
                product = productDAO.GetLastProduct();
                addImage(product);
            }
            else
            {
                //Update product
                pd.Category = selectedCategory;
                pd.Name = txtProductTitle.Text;
                pd.Type = txtType.Text;
                pd.OriginalPrice = StringToDouble(txtBuyPrice.Text);
                pd.SalePrice = StringToDouble(txtSellPrice.Text);
                pd.Area = selectedArea;
                pd.Condition = txtCondition.Text;
                pd.Status = txtStatus.Text;
                pd.SupportPolicy = txtSupportPolicy.Text;
                pd.Brand = txtBrand.Text;
                pd.Origin = txtOrigin.Text;
                pd.Material = txtMaterial.Text;
                pd.Size = txtSize.Text;
                pd.Functionality = txtFunctionalities.Text;
                pd.Description = txtDescription.Text;
                pd.CancelLimit = int.Parse(txtCancelTime.Text);
                pd.CancelRefund = cbCancel.Checked;
                productDAO.Update(pd, true);
                //Update Images (fix this code)
                imageDAO.Delete(pd.Id);
                addImage(pd);
            }
            this.Hide();
            FBuy f = new FBuy(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void addImage(Product product)
        {
            if (btnImage1.Image != null)
            {
                imageDAO.Add(product.Id, ImageToByteArray(btnImage1.Image));
            }
            if (btnImage2.Image != null)
            {
                imageDAO.Add(product.Id, ImageToByteArray(btnImage2.Image));
            }
            if (btnImage3.Image != null)
            {
                imageDAO.Add(product.Id, ImageToByteArray(btnImage3.Image));
            }
            if (btnImage4.Image != null)
            {
                imageDAO.Add(product.Id, ImageToByteArray(btnImage4.Image));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBuy f = new FBuy(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCart f = new FCart(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnPostProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSellDetail f = new FSellDetail(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnPurchasesOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FTrackOrder f = new FTrackOrder(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FProductManagement f = new FProductManagement(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSavedProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSaveList f = new FSaveList(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnOrderAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FOrderAnalysis f = new FOrderAnalysis(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FInformation f = new FInformation(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMoney f = new FMoney(acc);
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

        private void pbLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBuy f = new FBuy(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void GetImageProduct()
        {
            DataTable ImageTable = imageDAO.GetImageProduct(pd.Id);
            int pictureBoxIndex = 0;
            foreach (DataRow row in ImageTable.Rows)
            {
                if (pictureBoxIndex >= 4) // If we have more images than PictureBoxes
                    break;

                byte[] imageData = (byte[])row["Image"]; // Access the "Image" column

                // Load image into PictureBox
                MemoryStream ms = new MemoryStream(imageData);

                // Assign pictureBox variable based on index
                Guna2ImageButton pictureBox = null;

                switch (pictureBoxIndex)
                {

                    case 0:
                        pictureBox = btnImage1;
                        break;
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

                // Assign image to PictureBox and make it visible
                pictureBox.Image = Image.FromStream(ms);
                pictureBox.Visible = true;

                pictureBoxIndex++;
            }
            // Hide any remaining PictureBoxes
            if(!edit)
            {
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
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtCancelTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or the backspace key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If not a digit or backspace, ignore the input by marking the event as handled
                e.Handled = true;
            }
        }

        private void FSellDetail_Load(object sender, EventArgs e)
        {
            //Menu
            lblMenuAccountName.Text = acc.Name;
            ratingMenuAccount.Value = acc.AvgRating;
            convertByte(pbMenuAvatar, acc.Avatar);
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

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            this.Hide();
            FVoucher f = new FVoucher(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtBuyPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Không cho phép ký tự này điều khiển được nhập vào TextBox
                e.Handled = true;
            }
        }

        private void txtSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Không cho phép ký tự này điều khiển được nhập vào TextBox
                e.Handled = true;
            }
        }

        private void txtCondition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Không cho phép ký tự này điều khiển được nhập vào TextBox
                e.Handled = true;
            }
        }

        private void txtCancelTime_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Không cho phép ký tự này điều khiển được nhập vào TextBox
                e.Handled = true;
            }
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

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedItem != null)
            {
                selectedCategory = cbCategory.SelectedItem.ToString();
            }
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbArea.SelectedItem != null)
            {
                selectedArea = cbArea.SelectedItem.ToString();
            }
        }
    }
}
