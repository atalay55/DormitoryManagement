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
    public partial class BlockForm : Form
    {

        BlockDal blockDal = new BlockDal();
        ListViewItem item;
        Block block;
        BaseValidator v = new BaseValidator();
        public BlockForm()
        {
            InitializeComponent();

            listView1.MouseClick += new MouseEventHandler(listView1_MouseClick);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BlockForm_Load(object sender, EventArgs e)
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

                List<Block> member = blockDal.GetAll((p => p.blockId.ToString() == (item.Text)));
                block = member[0];

                blockNameTxtBox.Text = block.blockName.ToString();

                materialTxtBox.Text = block.numberOfMaterial.ToString();

                studentTxtBox.Text = block.numberOfStudents.ToString();


            }


        }
        private void showAllPerson()
        {
            foreach (Block blc in blockDal.GetAll())
            {

                item = new ListViewItem(blc.blockId.ToString());
                item.SubItems.Add(blc.blockName.ToString());
                item.SubItems.Add(blc.numberOfMaterial.ToString());
                item.SubItems.Add(blc.numberOfStudents.ToString());
      
                listView1.Items.Add(item);
            }


        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (v.checkIsString(blockNameTxtBox.Text)) {
                MessageBox.Show((v.checkIsString(blockNameTxtBox.Text).ToString()));
                blockDal.Add(new Block { blockName = char.Parse(blockNameTxtBox.Text) ,numberOfMaterial= int.Parse(materialTxtBox.Text),numberOfStudents=int.Parse(studentTxtBox.Text)});
                BlockForm blockForm = new BlockForm();
                blockForm.Show();
                this.Hide();
            }
           
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (v.checkIsString(blockNameTxtBox.Text))
            {
                block.blockName = char.Parse(blockNameTxtBox.Text);
                block.numberOfMaterial = int.Parse(materialTxtBox.Text);
                block.numberOfStudents = int.Parse(studentTxtBox.Text);
                blockDal.Update(block);
                BlockForm blockForm = new BlockForm();
                blockForm.Show();
                this.Hide();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            blockDal.Delete(block);
            BlockForm blockForm = new BlockForm();
            blockForm.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            ParentForm parentForm = new ParentForm();
            parentForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmergencyContactForm emergencyContactForm = new EmergencyContactForm();
            emergencyContactForm.Show();
            this.Hide();
        }
        private void BlockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm();
            roomForm.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            PublicAreaForm publicAreaForm = new PublicAreaForm();
            publicAreaForm.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
        }



    }
}
