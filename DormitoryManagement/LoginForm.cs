using DormitoryManagement.DataAccess.Concrete;
using DormitoryManagement.Enitity.Concrete;
using System;

using System.Windows.Forms;

namespace DormitoryManagement
{
    public partial class LoginForm : Form
    {
        EmployeeDal empDal = new EmployeeDal();

        public object MassageBox { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            foreach (Employee emp in empDal.GetAll()) {

                if (emp.firstName == nameTxtBox.Text && emp.ssn == passTxtBox.Text) {
                  
                    StudentForm studentForm = new StudentForm();
                    studentForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("giris başarısız");
          

                }
                
            }

            

            
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
