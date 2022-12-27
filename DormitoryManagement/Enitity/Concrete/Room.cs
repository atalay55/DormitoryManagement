using DormitoryManagement.Enitity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DormitoryManagement.DataAccess.Concrete
{
    [Table("Room")]
    public class Room : IEntity
    {
        [Key]
        public int roomId { get; set; }
        public int roomNumber { get; set; }
        public int numOfPerson { get; set; }
        public int numOfCabinet { get; set; }
        public int numOfBed { get; set; }
        [ForeignKey("Block")]
        public string blockName { get; set; }
        public string typeofRoom { get; set; }

    }
}
