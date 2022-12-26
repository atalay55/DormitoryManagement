using DormitoryManagement.View.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DormitoryManagement.View.Concrete
{
    public class MaleStudentsDto :IDto
    {
        public int id { get; set; }
        public int firstName { get; set; }

        public int lastName { get; set; }

        public int collegeNumber { get; set; }

        public int phoneNumber { get; set; }

    }
}
