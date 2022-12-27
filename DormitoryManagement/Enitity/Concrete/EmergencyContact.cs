using DormitoryManagement.Enitity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DormitoryManagement.Enitity.Concrete
{
    [Table("EmergencyContact")]
    public class EmergencyContact: IEntity
    {
        [Key]
        public int emergencyId { get; set; }
        public string nameofEmergencyContact { get; set; }
        public string phoneNumber { get; set; }
    }
}
