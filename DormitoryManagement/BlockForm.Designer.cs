
using System;

namespace DormitoryManagement
{
    partial class BlockForm
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.blockNameTxtBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.BlockName = new System.Windows.Forms.ColumnHeader();
            this.MaterialNumber = new System.Windows.Forms.ColumnHeader();
            this.StudentNumber = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.materialTxtBox = new System.Windows.Forms.TextBox();
            this.studentTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(317, 475);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(115, 43);
            this.addBtn.TabIndex = 69;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(454, 475);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(115, 43);
            this.updateBtn.TabIndex = 68;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(592, 475);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(115, 43);
            this.deleteBtn.TabIndex = 67;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Block Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // blockNameTxtBox
            // 
            this.blockNameTxtBox.Location = new System.Drawing.Point(454, 299);
            this.blockNameTxtBox.Name = "blockNameTxtBox";
            this.blockNameTxtBox.Size = new System.Drawing.Size(227, 27);
            this.blockNameTxtBox.TabIndex = 64;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.BlockName,
            this.MaterialNumber,
            this.StudentNumber});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(309, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(422, 243);
            this.listView1.TabIndex = 62;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 80;
            // 
            // BlockName
            // 
            this.BlockName.Text = "BlockName";
            this.BlockName.Width = 100;
            // 
            // MaterialNumber
            // 
            this.MaterialNumber.Text = "MaterialNumber";
            this.MaterialNumber.Width = 120;
            // 
            // StudentNumber
            // 
            this.StudentNumber.Width = 120;
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
            this.panel1.Location = new System.Drawing.Point(40, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 604);
            this.panel1.TabIndex = 71;
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
            // materialTxtBox
            // 
            this.materialTxtBox.Location = new System.Drawing.Point(454, 344);
            this.materialTxtBox.Name = "materialTxtBox";
            this.materialTxtBox.Size = new System.Drawing.Size(227, 27);
            this.materialTxtBox.TabIndex = 72;
            // 
            // studentTxtBox
            // 
            this.studentTxtBox.Location = new System.Drawing.Point(454, 393);
            this.studentTxtBox.Name = "studentTxtBox";
            this.studentTxtBox.Size = new System.Drawing.Size(227, 27);
            this.studentTxtBox.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "MaterialNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "StudentsNumber";
            // 
            // BlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 656);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentTxtBox);
            this.Controls.Add(this.materialTxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blockNameTxtBox);
            this.Controls.Add(this.listView1);
            this.Name = "BlockForm";
            this.Text = "BlockForm";
            this.Load += new System.EventHandler(this.BlockForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox blockNameTxtBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader BlockName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox materialTxtBox;
        private System.Windows.Forms.TextBox studentTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader MaterialNumber;
        private System.Windows.Forms.ColumnHeader StudentNumber;
    }
}