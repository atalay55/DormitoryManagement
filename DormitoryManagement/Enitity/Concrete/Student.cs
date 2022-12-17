using DormitoryManagement.Enitity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DormitoryManagement.Enitity.Concrete
{
    [Table("Student")]
    public class Student : IEntity
    {
        [Key]
        [Column(Order =1)]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string ssn { get; set; }
        public string collegeNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string? phoneNumber{ get; set; }
        public string? birthDate { get; set; }
        public string? address { get; set; }
        public string? schollEmail { get; set; }
        public int? scholarshipRate { get; set; }
        public char? gender { get; set; }
        public int? amountOfPayment { get; set; }
        public string? formOfPayment { get; set; }
        public int blockNumberId { get; set; }
        public int roomNumberId { get; set; }


    }
}
