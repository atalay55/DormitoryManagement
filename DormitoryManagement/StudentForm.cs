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
    public partial class StudentForm : Form
    {

        StudentDal stDal = new StudentDal();
        BaseValidator validator = new BaseValidator();
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
                dateTimePic.Text = String.Format("{0:d/M/yyyy}", student.birthDate).ToString();
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
          
            stDal.Delete(student);

            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Hide();



        }


        private void showAllPerson()
        {



            foreach (Student s in stDal.GetAll())
            {

                item = new ListViewItem(s.id.ToString());
                item.SubItems.Add(s.ssn);
                item.SubItems.Add(s.collegeNumber);
                item.SubItems.Add(s.firstName);
                item.SubItems.Add(s.lastName);
                item.SubItems.Add(s.phoneNumber);
                item.SubItems.Add(s.address);
                item.SubItems.Add(String.Format("{0:dd/M/yyyy}", s.birthDate).ToString());
                item.SubItems.Add(s.schollEmail);
                item.SubItems.Add(s.gender.ToString());
                item.SubItems.Add(s.scholarshipRate.ToString());
                item.SubItems.Add(s.formOfPayment);
                item.SubItems.Add(stDal.GetBlock(p => p.blockId == s.blockNumberId).blockName.ToString());
                item.SubItems.Add(stDal.GetRoom(p => p.id == s.roomNumberId).typeofRoom.ToString());
                item.SubItems.Add(s.amountOfPayment.ToString());

                listView1.Items.Add(item);

            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            char gen = 'E';
           var date =dateTimePic.Value;
       


            if (genderRB1.Checked)
            {
                gen = 'E';

            }
            else if (genderRb2.Checked)
            {
                gen = 'K';

            }


            if (validator.checkIsInt(ssnTxtBox.Text) & validator.checkIsString(FirstNameTxtBox.Text) & validator.checkIsString(LastNameTxtBox.Text) & validator.checkIsString(addressTxtBox.Text)
            & validator.checkIsInt(collegeTxtBox.Text) & validator.checkIsInt(phoneTxtBox.Text) & validator.checkIsString(emailTxtBox.Text) & validator.checkIsString(formPaymentTxtBox.Text)
            & validator.checkIsInt(BlockNumTxtBox.Text) & validator.checkIsInt(roomNumTxtBox.Text) & validator.checkIsInt(amountTxtBox.Text) & validator.checkIsInt(RateTxtBox.Text))
            {


                stDal.Add(new Student()
                {

                    ssn = (ssnTxtBox.Text),
                    firstName = (FirstNameTxtBox.Text),
                    lastName = (LastNameTxtBox.Text),
                    address = (addressTxtBox.Text),
                    birthDate = new DateTime(date.Year,date.Month, date.Day),
                    collegeNumber = (collegeTxtBox.Text),
                    phoneNumber = (phoneTxtBox.Text),
                    schollEmail = (emailTxtBox.Text),
                    formOfPayment = (formPaymentTxtBox.Text),
                    blockNumberId = int.Parse((BlockNumTxtBox.Text)),
                    roomNumberId = int.Parse((roomNumTxtBox.Text)),
                    amountOfPayment = int.Parse((amountTxtBox.Text)),
                    scholarshipRate = int.Parse((RateTxtBox.Text)),
                    gender = gen


                });
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
                this.Hide();



            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var date = dateTimePic.Value;
            char gen = 'E';


            if (genderRB1.Checked)
            {
                gen = 'E';

            }
            else if (genderRb2.Checked)
            {
                gen = 'K';

            }

            if (validator.checkIsInt(ssnTxtBox.Text) & validator.checkIsString(FirstNameTxtBox.Text) & validator.checkIsString(LastNameTxtBox.Text) & validator.checkIsString(addressTxtBox.Text)
                & validator.checkIsInt(collegeTxtBox.Text) & validator.checkIsInt(phoneTxtBox.Text) & validator.checkIsString(emailTxtBox.Text) & validator.checkIsString(formPaymentTxtBox.Text)
                & validator.checkIsInt(BlockNumTxtBox.Text) & validator.checkIsInt(roomNumTxtBox.Text) & validator.checkIsInt(amountTxtBox.Text) & validator.checkIsInt(RateTxtBox.Text))
            {


                student.ssn = ssnTxtBox.Text;
                student.firstName = (FirstNameTxtBox.Text);
                student.lastName = (LastNameTxtBox.Text);
                student.address = (addressTxtBox.Text);
                student.birthDate = new DateTime(date.Year, date.Month, date.Day);
                student.collegeNumber = (collegeTxtBox.Text);
                student.phoneNumber = (phoneTxtBox.Text);
                student.schollEmail = (emailTxtBox.Text);
                student.formOfPayment = (formPaymentTxtBox.Text);
                student.blockNumberId = int.Parse((BlockNumTxtBox.Text));
                student.roomNumberId = int.Parse(roomNumTxtBox.Text);
                student.amountOfPayment = int.Parse((amountTxtBox.Text));
                student.scholarshipRate = int.Parse((RateTxtBox.Text));
                student.gender = gen;
                stDal.Update(student);
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
                this.Hide();


            }
             



        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void button7_Click(object sender, EventArgs e)
        {
            PublicAreaForm publicAreaForm = new PublicAreaForm();
            publicAreaForm.Show();
            this.Hide();
        }

        
    }
}
