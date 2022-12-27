
using System;

namespace DormitoryManagement
{
    partial class RoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.typeTxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blockNumTxtBox = new System.Windows.Forms.TextBox();
            this.bedNumTxtBox = new System.Windows.Forms.TextBox();
            this.cabinetNumTxtBox = new System.Windows.Forms.TextBox();
            this.personNumTxtBox = new System.Windows.Forms.TextBox();
            this.roomNumTxtBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.RoomNumber = new System.Windows.Forms.ColumnHeader();
            this.NumPerson = new System.Windows.Forms.ColumnHeader();
            this.numCabinet = new System.Windows.Forms.ColumnHeader();
            this.numBed = new System.Windows.Forms.ColumnHeader();
            this.BlockNumber = new System.Windows.Forms.ColumnHeader();
            this.typeRoom = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 121;
            this.label1.Text = "typeofRoom";
            // 
            // typeTxtBox
            // 
            this.typeTxtBox.Location = new System.Drawing.Point(806, 403);
            this.typeTxtBox.Name = "typeTxtBox";
            this.typeTxtBox.Size = new System.Drawing.Size(177, 27);
            this.typeTxtBox.TabIndex = 120;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(515, 476);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(111, 45);
            this.addBtn.TabIndex = 118;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(676, 476);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(111, 45);
            this.updateBtn.TabIndex = 117;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(821, 476);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(111, 45);
            this.deleteBtn.TabIndex = 116;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(410, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 115;
            this.label10.Text = "blockName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(720, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 114;
            this.label7.Text = "numOfBed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 113;
            this.label5.Text = "numOfCabinet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 112;
            this.label3.Text = "NumOfPerson";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 111;
            this.label2.Text = "RoomNumber";
            // 
            // blockNumTxtBox
            // 
            this.blockNumTxtBox.Location = new System.Drawing.Point(504, 400);
            this.blockNumTxtBox.Name = "blockNumTxtBox";
            this.blockNumTxtBox.Size = new System.Drawing.Size(177, 27);
            this.blockNumTxtBox.TabIndex = 110;
            // 
            // bedNumTxtBox
            // 
            this.bedNumTxtBox.Location = new System.Drawing.Point(806, 342);
            this.bedNumTxtBox.Name = "bedNumTxtBox";
            this.bedNumTxtBox.Size = new System.Drawing.Size(177, 27);
            this.bedNumTxtBox.TabIndex = 109;
            // 
            // cabinetNumTxtBox
            // 
            this.cabinetNumTxtBox.Location = new System.Drawing.Point(504, 342);
            this.cabinetNumTxtBox.Name = "cabinetNumTxtBox";
            this.cabinetNumTxtBox.Size = new System.Drawing.Size(177, 27);
            this.cabinetNumTxtBox.TabIndex = 108;
            // 
            // personNumTxtBox
            // 
            this.personNumTxtBox.Location = new System.Drawing.Point(806, 272);
            this.personNumTxtBox.Name = "personNumTxtBox";
            this.personNumTxtBox.Size = new System.Drawing.Size(177, 27);
            this.personNumTxtBox.TabIndex = 107;
            // 
            // roomNumTxtBox
            // 
            this.roomNumTxtBox.Location = new System.Drawing.Point(504, 272);
            this.roomNumTxtBox.Name = "roomNumTxtBox";
            this.roomNumTxtBox.Size = new System.Drawing.Size(177, 27);
            this.roomNumTxtBox.TabIndex = 106;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.RoomNumber,
            this.NumPerson,
            this.numCabinet,
            this.numBed,
            this.BlockNumber,
            this.typeRoom});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(378, 12);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(778, 196);
            this.listView1.TabIndex = 105;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 130;
            // 
            // RoomNumber
            // 
            this.RoomNumber.Text = "RoomNumber";
            this.RoomNumber.Width = 100;
            // 
            // NumPerson
            // 
            this.NumPerson.Text = "Person Number";
            this.NumPerson.Width = 100;
            // 
            // numCabinet
            // 
            this.numCabinet.Text = "Cabinet Num";
            this.numCabinet.Width = 100;
            // 
            // numBed
            // 
            this.numBed.Text = "Bed Number";
            this.numBed.Width = 100;
            // 
            // BlockNumber
            // 
            this.BlockNumber.Text = "BlockNumberId";
            this.BlockNumber.Width = 100;
            // 
            // typeRoom
            // 
            this.typeRoom.Text = "Room Type";
            this.typeRoom.Width = 145;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(59, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 604);
            this.panel1.TabIndex = 122;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(19, 509);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(199, 51);
            this.button7.TabIndex = 7;
            this.button7.Text = "PublicArea";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(19, 433);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(199, 51);
            this.button6.TabIndex = 6;
            this.button6.Text = "Block";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 357);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(199, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "Room";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "EmergencyContact";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "Parent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeTxtBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blockNumTxtBox);
            this.Controls.Add(this.bedNumTxtBox);
            this.Controls.Add(this.cabinetNumTxtBox);
            this.Controls.Add(this.personNumTxtBox);
            this.Controls.Add(this.roomNumTxtBox);
            this.Controls.Add(this.listView1);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typeTxtBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox blockNumTxtBox;
        private System.Windows.Forms.TextBox bedNumTxtBox;
        private System.Windows.Forms.TextBox cabinetNumTxtBox;
        private System.Windows.Forms.TextBox personNumTxtBox;
        private System.Windows.Forms.TextBox roomNumTxtBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader RoomNumber;
        private System.Windows.Forms.ColumnHeader NumPerson;
        private System.Windows.Forms.ColumnHeader numCabinet;
        private System.Windows.Forms.ColumnHeader numBed;
        private System.Windows.Forms.ColumnHeader BlockNumber;
        private System.Windows.Forms.ColumnHeader typeRoom;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}