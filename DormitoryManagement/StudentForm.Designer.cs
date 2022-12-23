
namespace DormitoryManagement
{
    partial class StudentForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.genderRb2 = new System.Windows.Forms.RadioButton();
            this.genderRB1 = new System.Windows.Forms.RadioButton();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.SSN = new System.Windows.Forms.ColumnHeader();
            this.ColageNum = new System.Windows.Forms.ColumnHeader();
            this.FirstName = new System.Windows.Forms.ColumnHeader();
            this.LastName = new System.Windows.Forms.ColumnHeader();
            this.Phone = new System.Windows.Forms.ColumnHeader();
            this.BirthDate = new System.Windows.Forms.ColumnHeader();
            this.Adress = new System.Windows.Forms.ColumnHeader();
            this.SchoolEmail = new System.Windows.Forms.ColumnHeader();
            this.Gender = new System.Windows.Forms.ColumnHeader();
            this.Rate = new System.Windows.Forms.ColumnHeader();
            this.FormOfPay = new System.Windows.Forms.ColumnHeader();
            this.BlockNumId = new System.Windows.Forms.ColumnHeader();
            this.RoomNumId = new System.Windows.Forms.ColumnHeader();
            this.AmountOfPayment = new System.Windows.Forms.ColumnHeader();
            this.EmergencyId = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ssnTxtBox = new System.Windows.Forms.TextBox();
            this.collegeTxtBox = new System.Windows.Forms.TextBox();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.RateTxtBox = new System.Windows.Forms.TextBox();
            this.amountTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePic = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.formPaymentTxtBox = new System.Windows.Forms.TextBox();
            this.BlockNumTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.roomNumTxtBox = new System.Windows.Forms.TextBox();
            this.emergencyIdTxtBox = new System.Windows.Forms.TextBox();
            this.parentTxtBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ParentName = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1051, 601);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(131, 41);
            this.addBtn.TabIndex = 82;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // genderRb2
            // 
            this.genderRb2.AutoSize = true;
            this.genderRb2.Location = new System.Drawing.Point(1291, 458);
            this.genderRb2.Name = "genderRb2";
            this.genderRb2.Size = new System.Drawing.Size(78, 24);
            this.genderRb2.TabIndex = 81;
            this.genderRb2.TabStop = true;
            this.genderRb2.Text = "Female";
            this.genderRb2.UseVisualStyleBackColor = true;
            // 
            // genderRB1
            // 
            this.genderRB1.AutoSize = true;
            this.genderRB1.Location = new System.Drawing.Point(1181, 458);
            this.genderRB1.Name = "genderRB1";
            this.genderRB1.Size = new System.Drawing.Size(63, 24);
            this.genderRB1.TabIndex = 80;
            this.genderRB1.TabStop = true;
            this.genderRB1.Text = "Male";
            this.genderRB1.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(1204, 601);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(131, 41);
            this.updateBtn.TabIndex = 54;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(1359, 601);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(131, 41);
            this.deleteBtn.TabIndex = 53;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.SSN,
            this.ColageNum,
            this.FirstName,
            this.LastName,
            this.Phone,
            this.BirthDate,
            this.Adress,
            this.SchoolEmail,
            this.Gender,
            this.Rate,
            this.FormOfPay,
            this.BlockNumId,
            this.RoomNumId,
            this.AmountOfPayment,
            this.EmergencyId,
            this.ParentName});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(273, 12);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(1311, 235);
            this.listView1.TabIndex = 52;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 50;
            // 
            // SSN
            // 
            this.SSN.Text = "SSN";
            this.SSN.Width = 100;
            // 
            // ColageNum
            // 
            this.ColageNum.Text = "ColageNum";
            this.ColageNum.Width = 100;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Name";
            this.FirstName.Width = 100;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.Width = 100;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 100;
            // 
            // BirthDate
            // 
            this.BirthDate.Text = "BirthDate";
            this.BirthDate.Width = 100;
            // 
            // Adress
            // 
            this.Adress.Text = "Adress";
            this.Adress.Width = 100;
            // 
            // SchoolEmail
            // 
            this.SchoolEmail.Text = "SchoolEmail";
            this.SchoolEmail.Width = 100;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 70;
            // 
            // Rate
            // 
            this.Rate.Text = "Rate";
            // 
            // FormOfPay
            // 
            this.FormOfPay.Text = "FormOfPay";
            this.FormOfPay.Width = 100;
            // 
            // BlockNumId
            // 
            this.BlockNumId.Text = "Block";
            this.BlockNumId.Width = 100;
            // 
            // RoomNumId
            // 
            this.RoomNumId.Text = "RoomType";
            this.RoomNumId.Width = 100;
            // 
            // AmountOfPayment
            // 
            this.AmountOfPayment.Text = "AmountOfPayment";
            this.AmountOfPayment.Width = 100;
            // 
            // EmergencyId
            // 
            this.EmergencyId.Text = "EmergencyId";
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 630);
            this.panel1.TabIndex = 84;
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
            // ssnTxtBox
            // 
            this.ssnTxtBox.Location = new System.Drawing.Point(367, 283);
            this.ssnTxtBox.Name = "ssnTxtBox";
            this.ssnTxtBox.Size = new System.Drawing.Size(174, 27);
            this.ssnTxtBox.TabIndex = 85;
            // 
            // collegeTxtBox
            // 
            this.collegeTxtBox.Location = new System.Drawing.Point(367, 332);
            this.collegeTxtBox.Name = "collegeTxtBox";
            this.collegeTxtBox.Size = new System.Drawing.Size(174, 27);
            this.collegeTxtBox.TabIndex = 86;
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(367, 381);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(174, 27);
            this.FirstNameTxtBox.TabIndex = 87;
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(367, 435);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(174, 27);
            this.LastNameTxtBox.TabIndex = 88;
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Location = new System.Drawing.Point(651, 283);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(166, 27);
            this.phoneTxtBox.TabIndex = 89;
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(651, 381);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(166, 27);
            this.addressTxtBox.TabIndex = 90;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(651, 435);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(166, 27);
            this.emailTxtBox.TabIndex = 91;
            // 
            // RateTxtBox
            // 
            this.RateTxtBox.Location = new System.Drawing.Point(974, 284);
            this.RateTxtBox.Name = "RateTxtBox";
            this.RateTxtBox.Size = new System.Drawing.Size(111, 27);
            this.RateTxtBox.TabIndex = 92;
            // 
            // amountTxtBox
            // 
            this.amountTxtBox.Location = new System.Drawing.Point(974, 334);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.Size = new System.Drawing.Size(111, 27);
            this.amountTxtBox.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "CollegeNum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "LastName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 98;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 99;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 100;
            this.label7.Text = "Address";
            // 
            // dateTimePic
            // 
            this.dateTimePic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePic.Location = new System.Drawing.Point(651, 332);
            this.dateTimePic.Name = "dateTimePic";
            this.dateTimePic.Size = new System.Drawing.Size(166, 27);
            this.dateTimePic.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 102;
            this.label8.Text = "S.Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(929, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 103;
            this.label9.Text = "Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(846, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 104;
            this.label10.Text = "Payment Amount";
            // 
            // formPaymentTxtBox
            // 
            this.formPaymentTxtBox.Location = new System.Drawing.Point(974, 381);
            this.formPaymentTxtBox.Name = "formPaymentTxtBox";
            this.formPaymentTxtBox.Size = new System.Drawing.Size(111, 27);
            this.formPaymentTxtBox.TabIndex = 105;
            // 
            // BlockNumTxtBox
            // 
            this.BlockNumTxtBox.Location = new System.Drawing.Point(974, 431);
            this.BlockNumTxtBox.Name = "BlockNumTxtBox";
            this.BlockNumTxtBox.Size = new System.Drawing.Size(111, 27);
            this.BlockNumTxtBox.TabIndex = 106;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(865, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 107;
            this.label11.Text = "Payment Form";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(910, 434);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 108;
            this.label12.Text = "BlockId";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1140, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 109;
            this.label13.Text = "RoomId";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1107, 337);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 110;
            this.label14.Text = "EmergencyID";
            // 
            // roomNumTxtBox
            // 
            this.roomNumTxtBox.Location = new System.Drawing.Point(1210, 283);
            this.roomNumTxtBox.Name = "roomNumTxtBox";
            this.roomNumTxtBox.Size = new System.Drawing.Size(125, 27);
            this.roomNumTxtBox.TabIndex = 111;
            // 
            // emergencyIdTxtBox
            // 
            this.emergencyIdTxtBox.Location = new System.Drawing.Point(1210, 332);
            this.emergencyIdTxtBox.Name = "emergencyIdTxtBox";
            this.emergencyIdTxtBox.Size = new System.Drawing.Size(125, 27);
            this.emergencyIdTxtBox.TabIndex = 112;
            // 
            // parentTxtBox
            // 
            this.parentTxtBox.Location = new System.Drawing.Point(1210, 377);
            this.parentTxtBox.Name = "parentTxtBox";
            this.parentTxtBox.Size = new System.Drawing.Size(125, 27);
            this.parentTxtBox.TabIndex = 113;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1139, 384);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 114;
            this.label15.Text = "ParentId";
            // 
            // ParentName
            // 
            this.ParentName.Text = "ParentName";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 716);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.parentTxtBox);
            this.Controls.Add(this.emergencyIdTxtBox);
            this.Controls.Add(this.roomNumTxtBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BlockNumTxtBox);
            this.Controls.Add(this.formPaymentTxtBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountTxtBox);
            this.Controls.Add(this.RateTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.phoneTxtBox);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.collegeTxtBox);
            this.Controls.Add(this.ssnTxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.genderRb2);
            this.Controls.Add(this.genderRB1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.listView1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.RadioButton genderRb2;
        private System.Windows.Forms.RadioButton genderRB1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader SSN;
        private System.Windows.Forms.ColumnHeader ColageNum;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader BirthDate;
        private System.Windows.Forms.ColumnHeader Adress;
        private System.Windows.Forms.ColumnHeader SchoolEmail;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader FormOfPay;
        private System.Windows.Forms.ColumnHeader BlockNumId;
        private System.Windows.Forms.ColumnHeader RoomNumId;
        private System.Windows.Forms.ColumnHeader AmountOfPayment;
        private System.Windows.Forms.ColumnHeader Rate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ssnTxtBox;
        private System.Windows.Forms.TextBox collegeTxtBox;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox RateTxtBox;
        private System.Windows.Forms.TextBox amountTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox formPaymentTxtBox;
        private System.Windows.Forms.TextBox BlockNumTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox roomNumTxtBox;
        private System.Windows.Forms.ColumnHeader EmergencyId;
        private System.Windows.Forms.TextBox emergencyIdTxtBox;
        private System.Windows.Forms.TextBox parentTxtBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ColumnHeader ParentName;
    }
}