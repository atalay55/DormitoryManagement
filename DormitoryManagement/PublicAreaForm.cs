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
    public partial class PublicAreaForm : Form
    {
        PublicAreaDal pblDal = new PublicAreaDal();
        BlockDal blockDal = new BlockDal();
        ListViewItem item;
        PublicArea publicArea;
        BaseValidator v = new BaseValidator();
        public PublicAreaForm()
        {
            InitializeComponent();
            listView1.MouseClick += new MouseEventHandler(listView1_MouseClick);
        }

        private void PublicAreaForm_Load(object sender, EventArgs e)
        {
            showArea();


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

                List<PublicArea> member = pblDal.GetAll((p => p.idOfMaterial.ToString() == (item.Text)));
                publicArea = member[0];

               priceOfMaterialsTxtBox.Text = publicArea.priceOfMaterials.ToString();
                blockNumberIdTxtBox.Text = publicArea.blockName.ToString();
                

            }


        }
        private void showArea()
        {
            foreach (PublicArea pbl in pblDal.GetAll())
            {

                item = new ListViewItem(pbl.idOfMaterial.ToString());
                item.SubItems.Add(pbl.priceOfMaterials.ToString());
               item.SubItems.Add(blockDal.Get(p=>p.blockName==pbl.blockName).blockName.ToString());
                listView1.Items.Add(item);
            }


        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (v.checkIsInt(priceOfMaterialsTxtBox.Text) & v.checkIsString(blockNumberIdTxtBox.Text))
            {
                pblDal.Add(new PublicArea { priceOfMaterials = int.Parse( priceOfMaterialsTxtBox.Text), blockName =char.Parse( blockNumberIdTxtBox.Text )});
                PublicAreaForm publicAreaForm = new PublicAreaForm();
                publicAreaForm.Show();
                this.Hide();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (v.checkIsInt(priceOfMaterialsTxtBox.Text) & v.checkIsString(blockNumberIdTxtBox.Text))
            {
                publicArea.priceOfMaterials = int.Parse(priceOfMaterialsTxtBox.Text);
                publicArea.blockName = char.Parse(blockNumberIdTxtBox.Text);
                pblDal.Update(publicArea);
                PublicAreaForm publicAreaForm = new PublicAreaForm();
                publicAreaForm.Show();
                this.Hide();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            pblDal.Delete(publicArea);
            PublicAreaForm publicAreaForm = new PublicAreaForm();
            publicAreaForm.Show();
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
        private void PublicAreaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
