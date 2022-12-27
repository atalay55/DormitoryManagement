using DormitoryManagement.Enitity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DormitoryManagement.Enitity.Concrete
{
    [Table("Parent")]
    public class Parent :  IEntity
    {
        
        public int parentId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string? address { get; set; }
        public string? email { get; set; }
        public string contactStudentSsn { get; set; }
    
    }
}
