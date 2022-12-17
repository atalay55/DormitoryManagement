using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DormitoryManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (nameTxtBox.Text == "fatih" && passTxtBox.Text == "123") {

                StudentForm studentForm = new StudentForm();
                studentForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");

            }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
