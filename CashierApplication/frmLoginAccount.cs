using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Cashier cashier1 = new Cashier("Juan Dela Cruz", "Finance", "Cashier", "Cashier");

            if(cashier1.validateLogin(usernameInput.Text, passwordInput.Text))
            {
                MessageBox.Show($"Welcome, {cashier1.getName()} of {cashier1.getDepartment()}!");
                Form1 cashierPage = new Form1();
                cashierPage.Show();
            }
            else
            {
                MessageBox.Show($"Invalid Credentials!");
            }
        }
    }
    abstract class UserAccount
    {
        protected string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string uName, string password)
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_password = password;
        }
        public bool validateLogin(string uName, string password)
        {
            if(uName.Equals(user_name) && password.Equals(user_password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uName, string password) : base(name, uName, password)
        {
            this.full_name = name;
            this.department = department;
            this.user_name = uName;
            this.user_password = password;
        }
        public bool validateLogin(string uName, string password)
        {
            if (uName.Equals(user_name) && password.Equals(user_password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getDepartment()
        {
            return department;
        }
        public string getName()
        {
            return full_name;
        }
    }
}
