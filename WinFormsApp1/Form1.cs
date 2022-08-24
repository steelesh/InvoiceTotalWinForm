using Microsoft.VisualBasic;
using System.Diagnostics.CodeAnalysis;
using System.DirectoryServices;
using System.Security.Principal;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            var discountPercent = 0m;
            if (subtotal >= 50 && subtotal <= 100)
            {
                discountPercent = 0.1m;
            }
            else if (subtotal > 100 && subtotal <= 150)
            {
                discountPercent = 0.15m;
            }
            else if (subtotal > 150)
            {
                discountPercent = 0.2m;
            }
            var discountAmount = subtotal * (discountPercent);

            var total = subtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("P2");
            txtDiscountAmount.Text = discountAmount.ToString("C");
            txtTotal.Text = total.ToString("C");
        }
    }
}