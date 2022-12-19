using DormitoryManagement.Enitity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DormitoryManagement.Enitity.Concrete
{
    [Table("Employee")]
    public class Employee :  IEntity
    {

        public int id { get; set; }
        public string ssn { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string? phoneNumber { get; set; }
        public string? workingArea { get; set; }
        public double salary { get; set; }
        public DateTime? birthDate { get; set; }
        public string? address { get; set; }
        public char gender { get; set; }
        public int? holidays { get; set; }

    }
}