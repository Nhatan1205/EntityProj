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
    public partial class FInformation : Form
    {
        private AccountDAO accountDAO = new AccountDAO();
        private string imagePath = "";
        private byte[] avatarByteArray = null;
        Account account = new Account();
        public FInformation()
        {
            InitializeComponent();
            containerMenu.Visible = false;


        }

        public FInformation(Account acc)
        {
            InitializeComponent();
            containerMenu.Visible = false;
            this.account = acc;
            txtEmail.Text = account.Email;
            txtPassword.Text = "";
            txtName.Text = account.Name;
            txtAddress.Text = account.Address;
            txtPhone.Text = account.Phone;
            if (account.Birthday != DateTime.MinValue)
            {
                dtpBirthday.Value = account.Birthday.Date;
            }
            else
            {
                dtpBirthday.Value = DateTime.Today; 
            }
            convertByte(pbAvatar, account.Avatar);

            
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

        private System.Drawing.Image ResizeImage(System.Drawing.Image image, int width, int height)
        {
            // Tạo một Bitmap mới với kích thước đã cho
            Bitmap result = new Bitmap(width, height);

            // Tạo Graphics để vẽ hình ảnh vào Bitmap mới
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(image, 0, 0, width, height);
            }

            return result;
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

       

        private void FInformation_Load(object sender, EventArgs e)
        {
            ratingAcc.Value = account.AvgRating;
            //menu 
            lblMenuAccountName.Text = account.Name;
            ratingMenuAccount.Value = account.AvgRating;
            convertByte(pbMenuAvatar, account.Avatar);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignin f = new FSignin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = dialog.FileName.ToString();

                // Đọc hình ảnh từ tệp
                System.Drawing.Image originalImage = System.Drawing.Image.FromFile(imagePath);

                // Thay đổi kích thước của hình ảnh
                System.Drawing.Image resizedImage = ResizeImage(originalImage, pbAvatar.Width, pbAvatar.Height);

                // Hiển thị hình ảnh trong PictureBox
                pbAvatar.Image = resizedImage;

                // Đọc dữ liệu hình ảnh thành mảng byte
                using (FileStream fs = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    BinaryReader br = new BinaryReader(fs);
                    avatarByteArray = br.ReadBytes((int)fs.Length);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            account.Name = txtName.Text;
            account.Email = txtEmail.Text;
            if (txtPassword.Text.Length > 0)
            {
                account.Password = txtPassword.Text;
            }
            account.Phone = txtPhone.Text;
            account.Birthday = dtpBirthday.Value;
            account.Address = txtAddress.Text;
            account.Avatar = avatarByteArray;

            accountDAO.update(account);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBuy f = new FBuy(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            this.Hide();
            FVoucher f = new FVoucher(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBuy f = new FBuy(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
