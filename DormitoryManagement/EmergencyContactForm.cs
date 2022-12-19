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
    public partial class EmergencyContactForm : Form
    {

        EmergencyContactDal emcDal = new EmergencyContactDal();
        ListViewItem item;
        EmergencyContact emergencyContact;
        BaseValidator v = new BaseValidator();
        public EmergencyContactForm()
        {
            
            InitializeComponent();
            listView1.MouseClick += new MouseEventHandler(listView1_MouseClick);
        }

        private void EmergencyContactForm_Load(object sender, EventArgs e)
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

                List<EmergencyContact> member = emcDal.GetAll((p => p.id.ToString() == (item.Text)));
                emergencyContact = member[0];

                nameOfEmTxtBox.Text = emergencyContact.nameofEmergenceContact;
                phoneNumTxtBox.Text = emergencyContact.phoneNumber.ToString();


            }


        }
        private void showAllPerson()
        {
            foreach (EmergencyContact emc in emcDal.GetAll())
            {

                item = new ListViewItem(emc.id.ToString());
                item.SubItems.Add(emc.nameofEmergenceContact);
                item.SubItems.Add(emc.phoneNumber.ToString());
                listView1.Items.Add(item);
            }


        }
        private void addBtn_Click(object sender, EventArgs e)
        {

            if (v.checkIsString(nameOfEmTxtBox.Text) & v.checkIsInt(phoneNumTxtBox.Text))
            {
                emcDal.Add(new EmergencyContact { nameofEmergenceContact = nameOfEmTxtBox.Text, phoneNumber = int.Parse(phoneNumTxtBox.Text) });
                EmergencyContactForm emergencyContactForm = new EmergencyContactForm();
                emergencyContactForm.Show();
                this.Hide();
            }

            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            emcDal.Delete(emergencyContact);
            EmergencyContactForm emergencyContactForm = new EmergencyContactForm();
            emergencyContactForm.Show();
            this.Hide();
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void EmergencyContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
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

        private void updateBtn_Click(object sender, EventArgs e)
        {


            if (v.checkIsString(nameOfEmTxtBox.Text) & v.checkIsInt(phoneNumTxtBox.Text))
            {
                emergencyContact.nameofEmergenceContact = nameOfEmTxtBox.Text;
                emergencyContact.phoneNumber = int.Parse(phoneNumTxtBox.Text);
                emcDal.Update(emergencyContact);
                EmergencyContactForm emergencyContactForm = new EmergencyContactForm();
                emergencyContactForm.Show();
                this.Hide();
            }
        }
    }
}
