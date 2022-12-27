
namespace DormitoryManagement
{
    partial class PublicAreaForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blockNumberIdTxtBox = new System.Windows.Forms.TextBox();
            this.priceOfMaterialsTxtBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.MaterialPrice = new System.Windows.Forms.ColumnHeader();
            this.BlockName = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(57, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 604);
            this.panel1.TabIndex = 70;
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
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(375, 445);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(117, 43);
            this.addBtn.TabIndex = 69;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(519, 445);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(117, 43);
            this.updateBtn.TabIndex = 68;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(657, 445);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(117, 43);
            this.deleteBtn.TabIndex = 67;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "blockNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "priceOfMaterials";
            // 
            // blockNumberIdTxtBox
            // 
            this.blockNumberIdTxtBox.Location = new System.Drawing.Point(507, 369);
            this.blockNumberIdTxtBox.Name = "blockNumberIdTxtBox";
            this.blockNumberIdTxtBox.Size = new System.Drawing.Size(225, 27);
            this.blockNumberIdTxtBox.TabIndex = 64;
            // 
            // priceOfMaterialsTxtBox
            // 
            this.priceOfMaterialsTxtBox.Location = new System.Drawing.Point(507, 311);
            this.priceOfMaterialsTxtBox.Name = "priceOfMaterialsTxtBox";
            this.priceOfMaterialsTxtBox.Size = new System.Drawing.Size(225, 27);
            this.priceOfMaterialsTxtBox.TabIndex = 63;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.MaterialPrice,
            this.BlockName});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(373, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(401, 261);
            this.listView1.TabIndex = 62;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Materialid";
            this.id.Width = 130;
            // 
            // MaterialPrice
            // 
            this.MaterialPrice.Text = "MaterialPrice";
            this.MaterialPrice.Width = 130;
            // 
            // BlockName
            // 
            this.BlockName.Text = "BlockName";
            this.BlockName.Width = 130;
            // 
            // PublicAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blockNumberIdTxtBox);
            this.Controls.Add(this.priceOfMaterialsTxtBox);
            this.Controls.Add(this.listView1);
            this.Name = "PublicAreaForm";
            this.Text = "PublicAreaForm";
            this.Load += new System.EventHandler(this.PublicAreaForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox blockNumberIdTxtBox;
        private System.Windows.Forms.TextBox priceOfMaterialsTxtBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader MaterialPrice;
        private System.Windows.Forms.ColumnHeader BlockName;
        private System.Windows.Forms.Button button7;
    }
}