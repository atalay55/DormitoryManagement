using DormitoryManagement.View.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DormitoryManagement.View.Concrete
{
    public class MaleStudentsDto :IDto
    {
        public int StudentId { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string collegeNumber { get; set; }

        public string phoneNumber { get; set; }

    }
}
