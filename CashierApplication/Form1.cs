using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class Form1 : Form
    {
        DiscountedItem item1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            item1 = new DiscountedItem(itemInput.Text, Convert.ToDouble(priceInput.Text), Convert.ToInt32(quantityInput.Text), Convert.ToDouble(percentInput.Text));

            item1.setPayment();

            amountOutput.Text = Convert.ToString(item1.getTotalPrice());
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            paymentOutput.Text = Convert.ToString(item1.getChange(Convert.ToDouble(paymentInput.Text)));
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLoginAccount loginPage = new frmLoginAccount();
            loginPage.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
    abstract class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;

        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }
        public double getTotalPrice()
        {
            return this.total_price;
        }
        public void setPayment(double amount)
        {
            this.total_price = this.getTotalPrice() * amount;
        }
    }
    class DiscountedItem : Item
    {
        private double item_discount, discounted_price, payment_amount;

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
            this.item_discount = discount;
        }
        public double getTotalPrice()
        {
            return this.payment_amount;
        }
        public void setPayment()
        {
            double discountVal;

            item_discount *= 0.01;
            discountVal = item_discount * item_price;
            discounted_price = item_price - discountVal;
            payment_amount = discounted_price * item_quantity;
        }
        public double getChange(double amount)
        {
            return amount - payment_amount;
        }
    }


}
