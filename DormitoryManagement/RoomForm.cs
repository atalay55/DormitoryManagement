using DormitoryManagement.DataAccess.Concrete;
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
    public partial class RoomForm : Form
    {

        RoomDal roomDal = new RoomDal();
        ListViewItem item;
        Room room;
        BaseValidator v = new BaseValidator();
        public RoomForm()
        {
            InitializeComponent();
            listView1.MouseClick += new MouseEventHandler(listView1_MouseClick);
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            showRoom();


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

                List<Room> member = roomDal.GetAll((p => p.roomId.ToString() == (item.Text)));
                room = member[0];

                roomNumTxtBox.Text = room.roomNumber.ToString();
                bedNumTxtBox.Text = room.numOfBed.ToString();
                personNumTxtBox.Text = room.numOfPerson.ToString();
                cabinetNumTxtBox.Text = room.numOfCabinet.ToString();
                blockNumTxtBox.Text = room.blockId.ToString();
                typeTxtBox.Text = room.typeofRoom;

                

                

            }


        }

        private void showRoom()
        {
            foreach (Room rom in roomDal.GetAll())
            {

                item = new ListViewItem(rom.roomId.ToString());
                item.SubItems.Add(rom.roomNumber.ToString());
                item.SubItems.Add(rom.numOfPerson.ToString());
                item.SubItems.Add(rom.numOfCabinet.ToString());
                item.SubItems.Add(rom.numOfBed.ToString());
                item.SubItems.Add(rom.blockId.ToString());
                item.SubItems.Add(rom.typeofRoom);

                listView1.Items.Add(item);
            }


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
            
        }
        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (  v.checkIsInt(blockNumTxtBox.Text) & v.checkIsInt(bedNumTxtBox.Text) &v.checkIsInt(cabinetNumTxtBox.Text) & v.checkIsInt(personNumTxtBox.Text) & v.checkIsInt(roomNumTxtBox.Text) & v.checkIsString(typeTxtBox.Text))
            {
                roomDal.Add(new Room()
                {
                    blockId = int.Parse(blockNumTxtBox.Text),
                    numOfBed = int.Parse(bedNumTxtBox.Text),
                    numOfCabinet = int.Parse(cabinetNumTxtBox.Text),
                    numOfPerson = int.Parse(personNumTxtBox.Text),
                    roomNumber = int.Parse(roomNumTxtBox.Text),
                    typeofRoom = typeTxtBox.Text
                });
                RoomForm roomForm = new RoomForm();
                roomForm.Show();
                this.Hide();
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

        private void button6_Click(object sender, EventArgs e)
        {
            BlockForm blockForm = new BlockForm();
            blockForm.Show();
            this.Hide();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(v.checkIsInt(blockNumTxtBox.Text) & v.checkIsInt(bedNumTxtBox.Text) & v.checkIsInt(cabinetNumTxtBox.Text) & v.checkIsInt(personNumTxtBox.Text) & v.checkIsInt(roomNumTxtBox.Text) & v.checkIsString(typeTxtBox.Text))
            {
                room.numOfBed = int.Parse(bedNumTxtBox.Text);
                room.numOfCabinet = int.Parse(cabinetNumTxtBox.Text);
                room.numOfPerson = int.Parse(personNumTxtBox.Text);
                room.roomNumber = int.Parse(cabinetNumTxtBox.Text);
                room.typeofRoom = typeTxtBox.Text;
                room.blockId = int.Parse(blockNumTxtBox.Text);
                roomDal.Update(room);
                RoomForm roomForm = new RoomForm();
                roomForm.Show();
                this.Hide();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            roomDal.Delete(room);
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

        
    }
}
