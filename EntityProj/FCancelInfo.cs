﻿using System;
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

namespace EntityProj.Forms
{
    public partial class FCancelInfo : Form
    {
        CancelInfoDAO cancelInfoDAO = new CancelInfoDAO();
        Account account = new Account();
        Product product = new Product();
        AccountDAO accountDAO = new AccountDAO();
        ProductDAO productDAO = new ProductDAO();
        private CartDAO cartDAO = new CartDAO();
        private FavoriteDAO favoriteDAO = new FavoriteDAO();
        private ImageDAO imageDAO = new ImageDAO();

        public FCancelInfo()
        {
            InitializeComponent();
        }

        public FCancelInfo(Account account,Product product)
        {
            InitializeComponent();
            this.account = account;
            this.product = product;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbReason.SelectedItem.ToString() == "Select a Reason")
            {
                MessageBox.Show("You have to choose a reason!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cancelInfoDAO.add(product.ID, account.ID, cbReason.SelectedItem.ToString(), txtExtraInfo.Text);
                //update status for product
                product.OrderCondition = (int)ordercondition.Displaying;
                productDAO.Update(product);
                productDAO.DeleteBuyerID(product);
                //get seller
                if (product.PayMethod.Value)
                {
                    Account Seller = accountDAO.Retrieve(product.SellerID.Value);
                    Seller.Money -= (float)product.SalePrice;
                    accountDAO.Update(Seller);
                }
                //refund if product is allowed to refund && Online payment
                if (product.CancelRefund.Value && product.PayMethod.Value)
                {
                    Account Buyer = accountDAO.Retrieve(product.BuyerID.Value);
                    Buyer.Money += (float)product.SalePrice;
                    accountDAO.Update(Buyer);
                }
                MessageBox.Show("Operation was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }     
        }

        private void FCancelInfo_Load(object sender, EventArgs e)
        {
            lblProductName.Text = product.Name;
            lblPrice.Text = product.SalePrice.ToString() + "VND";
            byte[] imageData = imageDAO.GetImageProductData(product.ID);
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Attempt to create Image object
                    try
                    {
                        pbProductImage.Image = System.Drawing.Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }
        }
    }
}
