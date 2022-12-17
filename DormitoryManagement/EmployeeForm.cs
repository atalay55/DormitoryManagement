﻿using DormitoryManagement.DataAccess.Concrete;
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
    public partial class EmployeeForm : Form
    {
        EmployeeDal empDal = new EmployeeDal();
        ListViewItem item;
        Employee employee;
        public EmployeeForm()
        {
            InitializeComponent();
            listView1.MouseClick += new MouseEventHandler(listView1_MouseClick);
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
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

                List<Employee> member = empDal.GetAll((p => p.id.ToString() == (item.Text)));
                employee = member[0];
                Console.WriteLine(member.Count);

                ssnTxtBox.Text = employee.ssn;
                nameTxtBox.Text = employee.firstName;
                lastNameTxtBox.Text = employee.lastName;
                addressTxtBox.Text = employee.address;
                dateTimePicker.Text = employee.birthDate;
                salaryTxtBox.Text = employee.salary.ToString();
                phoneTxtBox.Text = employee.phoneNumber;
                holidayTxtBox.Text = employee.holidays.ToString();
                workingAreaTxtBox.Text = employee.workingArea;
                if (employee.gender == 'K')
                {
                    genderRb2.Checked = true;
                }
                if (employee.gender == 'E')
                {
                    genderRB1.Checked = true;
                }

            }


        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            empDal.Add(saveEmployee());
        }



        public Employee saveEmployee()
        {
            char gen = 'E';


            if (genderRB1.Checked)
            {
                gen = 'E';

            }
            else if (genderRb2.Checked)
            {
                gen = 'K';

            }
            Employee st = new Employee()
            {
                ssn = ssnTxtBox.Text,
                firstName = nameTxtBox.Text,
                lastName = lastNameTxtBox.Text,
                address = addressTxtBox.Text,
                birthDate = dateTimePicker.Text,
                phoneNumber = phoneTxtBox.Text,
                salary = int.Parse(salaryTxtBox.Text),
                holidays = int.Parse(holidayTxtBox.Text),
                workingArea = workingAreaTxtBox.Text,
                gender = gen
            };

            return st;
        }



        private void showAllPerson()
        {



            foreach (Employee s in empDal.GetAll())
            {

                item = new ListViewItem(s.id.ToString());
                item.SubItems.Add(s.ssn);
                item.SubItems.Add(s.firstName);
                item.SubItems.Add(s.lastName);
                item.SubItems.Add(s.phoneNumber);
                item.SubItems.Add(s.birthDate);
                item.SubItems.Add(s.address);
                item.SubItems.Add(s.workingArea);
                item.SubItems.Add(s.gender.ToString());
                item.SubItems.Add(s.salary.ToString());
                item.SubItems.Add(s.holidays.ToString());
                listView1.Items.Add(item);

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            empDal.Delete(employee);
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmergencyContactForm emergencyContactForm = new EmergencyContactForm();
            emergencyContactForm.Show();
            this.Hide();
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


            char gen = 'E';


            if (genderRB1.Checked)
            {
                gen = 'E';

            }
            else if (genderRb2.Checked)
            {
                gen = 'K';

            }

            employee.ssn = ssnTxtBox.Text;
            employee.firstName = nameTxtBox.Text;
            employee.lastName = lastNameTxtBox.Text;
            employee.address = addressTxtBox.Text;
            employee.birthDate = dateTimePicker.Text;
            employee.phoneNumber = phoneTxtBox.Text;
            employee.salary = int.Parse(salaryTxtBox.Text);
            employee.holidays = int.Parse(holidayTxtBox.Text);
            employee.workingArea = workingAreaTxtBox.Text;
            employee.gender = gen;

            empDal.Update(employee);
        }
    }



   
}
