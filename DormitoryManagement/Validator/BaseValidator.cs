using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DormitoryManagement.Validator
{
    public class BaseValidator
    {
    
        public bool checkIsString(String a) {
            
            if (String.IsNullOrEmpty(a))
            {
                MessageBox.Show(a +"cannot be empty");
                return false;

            }
            if (!Regex.Match(a, @"^[[a-zA-Z]*$").Success)
            {
                MessageBox.Show(a+" please enter string value");
                return false;
            }
           
            return true;
        }

     

         
        public bool checkIsInt(String a)
        {
            if (String.IsNullOrEmpty(a))
            {
                MessageBox.Show(a + " cannot be empty");
           
               return false;
            }
            if (!Regex.Match(a, @"^\d+$").Success)
            {
                MessageBox.Show(a +" please enter int value");
             
                return false;
            }
            return true;
        }
    }
}
