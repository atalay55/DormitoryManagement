using DormitoryManagement.DataAccess.Concrete;
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
        public RoomForm()
        {
            InitializeComponent();
            listView1.MouseClick += new MouseEventHandler(listView1_MouseClick);
        }

        private void label10_Click(object sender, EventArgs e)
        {

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

                List<Room> member = roomDal.GetAll((p => p.id.ToString() == (item.Text)));
                room = member[0];

                roomNumTxtBox.Text = room.roomNumber.ToString();
                bedNumTxtBox.Text = room.numOfBed.ToString();
                personNumTxtBox.Text = room.numOfPerson.ToString();
                cabinetNumTxtBox.Text = room.numOfCabinet.ToString();
                blockNumTxtBox.Text = room.blockNumberId.ToString();
                typeTxtBox.Text = room.typeofRoom;

                

                

            }


        }

        private void showRoom()
        {
            foreach (Room rom in roomDal.GetAll())
            {

                item = new ListViewItem(rom.id.ToString());
                item.SubItems.Add(rom.roomNumber.ToString());
                item.SubItems.Add(rom.numOfPerson.ToString());
                item.SubItems.Add(rom.numOfCabinet.ToString());
                item.SubItems.Add(rom.numOfBed.ToString());
                item.SubItems.Add(rom.blockNumberId.ToString());
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
        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            roomDal.Add(new Room() { blockNumberId =int.Parse(blockNumTxtBox.Text),numOfBed=int.Parse(bedNumTxtBox.Text),
                numOfCabinet = int.Parse(cabinetNumTxtBox.Text),numOfPerson=int.Parse(personNumTxtBox.Text),
            roomNumber=int.Parse(roomNumTxtBox.Text),typeofRoom=typeTxtBox.Text});

       
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
            room.numOfBed = int.Parse(bedNumTxtBox.Text);
            room.numOfCabinet= int.Parse(cabinetNumTxtBox.Text);
            room.numOfPerson= int.Parse(personNumTxtBox.Text);
            room.roomNumber= int.Parse(cabinetNumTxtBox.Text);
            room.typeofRoom = typeTxtBox.Text;
            room.blockNumberId= int.Parse(blockNumTxtBox.Text);
            roomDal.Update(room);

        }
    }
}
