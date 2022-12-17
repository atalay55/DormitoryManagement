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
    public partial class StudentForm : Form
    {

        StudentDal stDal = new StudentDal();
        ListViewItem item;

        Student student;
        public StudentForm()
        {
            InitializeComponent();
            listView1.MouseClick += new MouseEventHandler(listView1_MouseClick);
        }


        void listView1_MouseClick(object sender, MouseEventArgs e)

        {

            ListViewItem theClickedOne = listView1.GetItemAt(e.X, e.Y);

            if (theClickedOne != null)

            {


                var item = listView1.SelectedItems[0];

                List<Student> member = stDal.GetAll((p => p.id.ToString() == (item.Text)));
                student = member[0];
                Console.WriteLine(member.Count);

                ssnTxtBox.Text = student.ssn;
                FirstNameTxtBox.Text = student.firstName;
                LastNameTxtBox.Text = student.lastName;
                addressTxtBox.Text = student.address;
                dateTimePic.Text = student.birthDate;
                collegeTxtBox.Text = student.collegeNumber;
                phoneTxtBox.Text = student.phoneNumber;
                emailTxtBox.Text = student.schollEmail;
                formPaymentTxtBox.Text = student.formOfPayment;
                if (student.gender == 'K')
                {
                    genderRb2.Checked = true;
                }
                if (student.gender == 'E')
                {
                    genderRB1.Checked = true;
                }
                BlockNumTxtBox.Text = student.blockNumberId.ToString();
                roomNumTxtBox.Text = student.roomNumberId.ToString();
                amountTxtBox.Text = student.amountOfPayment.ToString();
                RateTxtBox.Text = student.scholarshipRate.ToString() ;


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

            showAllPerson();


            this.listView1.LabelEdit = true;
            this.listView1.FullRowSelect = true;
            this.listView1.Refresh();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.listView1.BeginUpdate();
            stDal.Delete(student);

            this.listView1.EndUpdate();



        }


        private void showAllPerson()
        {



            foreach (Student s in stDal.GetAll())
            {

                Console.WriteLine(s.amountOfPayment);
                item = new ListViewItem(s.id.ToString());
                item.SubItems.Add(s.ssn);
                item.SubItems.Add(s.collegeNumber);
                item.SubItems.Add(s.firstName);
                item.SubItems.Add(s.lastName);
                item.SubItems.Add(s.phoneNumber);
                item.SubItems.Add(s.birthDate);
                item.SubItems.Add(s.address);
                item.SubItems.Add(s.schollEmail);
                item.SubItems.Add(s.gender.ToString());
                item.SubItems.Add(s.scholarshipRate.ToString());
                item.SubItems.Add(s.formOfPayment);
                item.SubItems.Add(stDal.GetBlock(p => p.blockId == s.blockNumberId).blockNumber.ToString());
                item.SubItems.Add(stDal.GetRoom(p => p.id == s.roomNumberId).typeofRoom.ToString());
                item.SubItems.Add(s.amountOfPayment.ToString());

                listView1.Items.Add(item);

            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
          
            stDal.Add(saveStudent());
            
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

                student.ssn = ssnTxtBox.Text;
                   student.firstName = FirstNameTxtBox.Text;
                   student.lastName = LastNameTxtBox.Text;
                   student.address = addressTxtBox.Text;
                   student.birthDate = dateTimePic.Text;
                   student.collegeNumber = collegeTxtBox.Text;
                  student.phoneNumber = phoneTxtBox.Text;
                  student.schollEmail = emailTxtBox.Text;
                  student.formOfPayment = formPaymentTxtBox.Text;
                  student.blockNumberId = int.Parse(BlockNumTxtBox.Text);
                  student.roomNumberId = int.Parse(roomNumTxtBox.Text);
                   student.amountOfPayment = int.Parse(amountTxtBox.Text);
                  student.scholarshipRate = int.Parse(RateTxtBox.Text);
                  student.gender = gen;
            stDal.Update(student);

            

            }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        public Student saveStudent()
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
            Student st = new Student()
            {
                ssn = ssnTxtBox.Text,
                firstName = FirstNameTxtBox.Text,
                lastName = LastNameTxtBox.Text,
                address = addressTxtBox.Text,
                birthDate = dateTimePic.Text,
                collegeNumber = collegeTxtBox.Text,
                phoneNumber = phoneTxtBox.Text,
                schollEmail = emailTxtBox.Text,
                formOfPayment = formPaymentTxtBox.Text,
                blockNumberId = int.Parse(BlockNumTxtBox.Text),
                roomNumberId = int.Parse(roomNumTxtBox.Text),
                amountOfPayment = int.Parse(amountTxtBox.Text),
                scholarshipRate = int.Parse(RateTxtBox.Text),
                gender = gen
            };

            return st;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
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
    }
}
