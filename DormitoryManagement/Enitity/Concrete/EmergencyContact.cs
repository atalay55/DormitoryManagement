using DormitoryManagement.Enitity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DormitoryManagement.Enitity.Concrete
{
    [Table("EmergencyContact")]
    public class EmergencyContact: IEntity
    {
        public int id { get; set; }
        public string nameofEmergenceContact { get; set; }
        public int phoneNumber { get; set; }
    }
}
