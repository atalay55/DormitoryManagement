using DormitoryManagement.DataAccess.Concrete;
using DormitoryManagement.Enitity.Concrete;
using DormitoryManagement.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DormitoryManagement
{
    public partial class ParentForm : Form
    {

        ParentDal parentDal = new ParentDal();
        ListViewItem item;
        Parent parent;
        BaseValidator v = new BaseValidator();
        public ParentForm()
        {
            InitializeComponent();
            listView1.MouseClick += new MouseEventHandler(listView1_MouseClick);
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

            showAllPerson();


            this.listView1.LabelEdit = true;
            this.listView1.FullRowSelect = true;
            this.listView1.Refresh();
        }

        void listView1_MouseClick(object sender, MouseEventArgs e)

        {

            ListViewItem theClickedOne = listView1.GetItemAt(e.X, e.Y);

            if (theClickedOne != null)

            {
                var item = listView1.SelectedItems[0];

                List<Parent> member = parentDal.GetAll((p => p.id.ToString() == (item.Text)));
                parent = member[0];

                nameTxtBox.Text = parent.firstName;
                lastNameTxtBox.Text = parent.lastName;
                phoneTxtBox.Text = parent.phoneNumber;
                addressTxtBox.Text = parent.address;
                ContactTxtBox.Text = parent.contactStudentSsn;
                emailTxtBox.Text = parent.email;

            }


        }

        private void showAllPerson()
        {
            foreach (Parent par in parentDal.GetAll())
            {

                item = new ListViewItem(par.id.ToString());
                item.SubItems.Add(par.firstName);
                item.SubItems.Add(par.lastName);
                item.SubItems.Add(par.phoneNumber);
                item.SubItems.Add(par.address);
                item.SubItems.Add(par.contactStudentSsn);
                item.SubItems.Add(par.email);
                listView1.Items.Add(item);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmergencyContactForm emergencyContactForm = new EmergencyContactForm();
            emergencyContactForm.Show();
            this.Hide();

        }
        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            if (v.checkIsString(nameTxtBox.Text) & v.checkIsString(lastNameTxtBox.Text) & v.checkIsString(addressTxtBox.Text) & v.checkIsInt(ContactTxtBox.Text) & v.checkIsInt(phoneTxtBox.Text)) {


                parentDal.Add(new Parent()
                {
                    firstName = nameTxtBox.Text,
                    lastName = lastNameTxtBox.Text,
                    address = addressTxtBox.Text,
                    contactStudentSsn = ContactTxtBox.Text,
                    phoneNumber = phoneTxtBox.Text,
                    email = emailTxtBox.Text
                });
                ParentForm parentForm = new ParentForm();
                parentForm.Show();
                this.Hide();
            }
           
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            parentDal.Delete(parent);
            ParentForm parentForm = new ParentForm();
            parentForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm();
            roomForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BlockForm blockForm = new BlockForm();
            blockForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PublicAreaForm publicAreaForm = new PublicAreaForm();
            publicAreaForm.Show();
            this.Hide();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (v.checkIsString(nameTxtBox.Text) & v.checkIsString(lastNameTxtBox.Text) & v.checkIsString(addressTxtBox.Text) & v.checkIsInt(ContactTxtBox.Text) & v.checkIsInt(phoneTxtBox.Text)) {
                parent.firstName = nameTxtBox.Text;
                parent.lastName = lastNameTxtBox.Text;
                parent.phoneNumber = phoneTxtBox.Text;
                parent.address = addressTxtBox.Text;
                parent.contactStudentSsn = ContactTxtBox.Text;
                parent.email = emailTxtBox.Text;
                parentDal.Update(parent);
                ParentForm parentForm = new ParentForm();
                parentForm.Show();
                this.Hide();

            }
         
        }


     
    }
}
