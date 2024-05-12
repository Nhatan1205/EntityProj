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
using Guna.UI2.WinForms;
using EntityProj.Forms;

namespace EntityProj.Forms
{
    public partial class UCReview : UserControl
    {
        private ImageDAO imageDAO = new ImageDAO();
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private ProductDAO productDAO = new ProductDAO();
        private Product product;
        private Rating rating = new Rating();
        private RatingDAO ratingDAO = new RatingDAO();
        public UCReview()
        {
            InitializeComponent();
        }
        public UCReview(Product pd, Account acc, Rating rt)
        {
            InitializeComponent();
            this.product = pd;
            this.account = acc;
            this.rating = rt;
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
        private void UCReview_Load(object sender, EventArgs e)
        {
            Account Buyer = accountDAO.Retrieve(rating.BuyerID.Value);
            lblNameSeller.Text = Buyer.Name;
            convertByte(pbAvtSeller, Buyer.Avatar);
            string labeldata = rating.Comment;
            string[] ratings = labeldata.Split(';');
            //foreach(string label in ratings)
            //{
            //    GenerateLabel(panelRating, label, label.Length );
            //}
            for (int i = ratings.Length - 1; i >= 0; i--)
            {
                GenerateLabel(panelRating, ratings[i], ratings[i].Length);
            }
            lblStar.Text = rating.Star.ToString();
            rsStar.Value = (float)rating.Star;
            rsStar.ReadOnly = true;
            // edit UCProductCondition with minimalism
            ucProductConditionReduce.lblStatus.Visible = false;
            ucProductConditionReduce.lblPrice.Visible = false;
            ucProductConditionReduce.btnNextState.Visible = false;
            convertByte(ucProductConditionReduce.pictureBox1, imageDAO.GetImageProductData(rating.ProductID));
            ucProductConditionReduce.lblBuyerName.Text = product.SalePrice.ToString();
            ucProductConditionReduce.lblProductName.Text = product.Name;
        }
        private void GenerateLabel(Panel panel, string labelText, int labelCount)
        {
            Label label = new Label();
            label.Text = labelText;
            label.AutoSize = true; // Cho phép label tự điều chỉnh kích thước dựa trên nội dung
            label.Padding = new Padding(5);
            label.BorderStyle = BorderStyle.FixedSingle;
            label.BackColor = Color.White;
            label.ForeColor = Color.FromArgb(54, 50, 132);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Left;
            // Tính toán kích thước cho mỗi label
            int labelWidth = labelCount + 50;
            int labelHeight = 23;
            label.Size = new Size(labelWidth, labelHeight); // Đặt kích thước tối đa của label

            panel.Controls.Add(label);
        }

        private void gbContent_Enter(object sender, EventArgs e)
        {

        }
    }
}
