﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_Code
{
    public partial class FormMain : Form
    {
        public AppUser LoginUser = new AppUser();
        public FormMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
        private void LoginBttn_Click(object sender, EventArgs e)
        {
            FakeAppUserRepository test = new FakeAppUserRepository();
            string user_name = UserNameBox.Text;
            string password = PasswordBox.Text;
            bool result = test.Login(user_name, password);

            if (result == true)
            {
                test.SetAuthentication(user_name, result);
                LoginUser = test.GetByUserName(user_name);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect UsereName or Password. Try again!", "Attention");
            }
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
