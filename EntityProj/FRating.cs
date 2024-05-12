using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Guna.UI2.WinForms;
using EntityProj.Forms;

namespace EntityProj.Forms
{
    public partial class FRating : Form
    {
        private ImageDAO imageDAO = new ImageDAO();
        private Product product;
        private ProductDAO productDAO = new ProductDAO();
        private Rating rt = new Rating();
        private RatingDAO ratingDAO = new RatingDAO();
        public FRating()
        {
            InitializeComponent();
            rt.Comment = "";
        }
        public FRating(Product pd)
        {
            InitializeComponent();
            rt.Comment = "";
            this.product = pd;
            lblNameProduct.Text = product.Name;

            byte[] imageData = imageDAO.GetImageProductData(pd.ID);
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    try
                    {
                        pbProduct.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private float GetStarValue()
        {
            return rtStar.Value;
        }
        private void SetLabelStatus()
        {
            float star = GetStarValue();
            if(star >= 0 && star <= 1)
            {
                lblStatus.ForeColor = Color.WhiteSmoke;
                lblStatus.Text = "Bad";
            }
            else if(star > 1 && star <= 2)
            {
                lblStatus.ForeColor = Color.WhiteSmoke;
                lblStatus.Text = "Unsatisfied";
            }
            else if( star > 2 && star <= 3)
            {
                lblStatus.ForeColor = Color.WhiteSmoke;
                lblStatus.Text = "Normal";
            }
            else if (star > 3 && star <= 4)
            {
                lblStatus.ForeColor = Color.Yellow;
                lblStatus.Text = "Satisfied";
            }
            else
            {
                lblStatus.ForeColor = Color.Yellow;
                lblStatus.Text = "Great";
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            GetValueOfCheckBox();
            rt.Comment += txtComment.Text;
            rt.Star = GetStarValue();
            if (rt.Comment == null || rt.Star == 0)
            {
                MessageBox.Show("Data has not been filled!");
            }
            else
            {
                //ratingDAO.Add(rt, product);
            }
            ClearData();
            
        }

        private void rtStar_ValueChanged(object sender, EventArgs e)
        {
            SetLabelStatus();
        }
        private void ClearData()
        {
            foreach (Control control in panelCheckBox.Controls)
            {
                if (control is Guna2CheckBox checkBox)
                {
                    if (checkBox.Checked == true)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
            rt.Comment = "";
            rtStar.Value = 0;
            txtComment.Text = "";
        }
       
        
        private void GetValueOfCheckBox()
        {
           foreach(Control control in panelCheckBox.Controls)
            {
                if(control is Guna2CheckBox checkBox)
                {
                    if(checkBox.Checked == true)
                    {
                        string tmp = checkBox.Text;
                        rt.Comment += tmp;
                        rt.Comment += "; ";
                    }
                }
            }
           
           
        }


    }
}
