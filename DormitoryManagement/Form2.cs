using DormitoryManagement.DataAccess.Concrete;
using DormitoryManagement.Enitity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DormitoryManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void titleUser_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //  EmployeeDal stdal = new EmployeeDal();
            StudentDal stdal = new StudentDal();

            if (genderRB1.Checked)
            {
                stdal.Add(new Student()
                {
                    ssn = ssnTxtBox.Text,
                    firstName = nameTextBox.Text,
                    lastName = surnameTextBox.Text,
                    address = adressTextBox.Text,
                    birthDate = birthdateTextBox.Text,
                    collegeNumber = schoolnumTextBox.Text,
                    phoneNumber = phoneNumTextBox.Text,
                    schollEmail = emailTextBox.Text,
                    formOfPayment = formOfPaymentTextBox.Text,
                    blockNumberId = int.Parse(blockNumTextBox.Text),
                    roomNumberId = int.Parse(roomNumTextBox.Text)
           ,
                    gender = 'E'
                });

            }
            else if (genderRb2.Checked)
            {

                stdal.Add(new Student()
                {
                    ssn = ssnTxtBox.Text,
                    firstName = nameTextBox.Text,
                    lastName = surnameTextBox.Text,
                    address = adressTextBox.Text,
                    birthDate = birthdateTextBox.Text,
                    collegeNumber = schoolnumTextBox.Text,
                    phoneNumber = phoneNumTextBox.Text,
                    schollEmail = emailTextBox.Text,
                    formOfPayment = formOfPaymentTextBox.Text,
                    blockNumberId = int.Parse(blockNumTextBox.Text),
                    roomNumberId = int.Parse(roomNumTextBox.Text),
                    gender = 'K'
                });
            }
            
        
       
        

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
