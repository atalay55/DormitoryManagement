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
    public partial class BlockForm : Form
    {

        BlockDal blockDal = new BlockDal();
        ListViewItem item;
        Block block;
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

                blockNameTxtBox.Text = block.blockNumber.ToString();


            }


        }
        private void showAllPerson()
        {
            foreach (Block blc in blockDal.GetAll())
            {

                item = new ListViewItem(blc.blockId.ToString());
                item.SubItems.Add(blc.blockNumber.ToString());
      
                listView1.Items.Add(item);
            }


        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            blockDal.Add(new Block {blockNumber = char.Parse(blockNameTxtBox.Text) });
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            block.blockNumber = char.Parse(blockNameTxtBox.Text);
            blockDal.Update(block);

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            blockDal.Delete(block);
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
    }
}
