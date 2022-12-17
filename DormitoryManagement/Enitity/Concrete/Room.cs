using DormitoryManagement.Enitity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DormitoryManagement.DataAccess.Concrete
{
    public class Room : IEntity
    {
        public int id { get; set; }
        public int roomNumber { get; set; }
        public int numOfPerson { get; set; }
        public int numOfCabinet { get; set; }
        public int numOfBed { get; set; }
        public int blockNumberId { get; set; }
        public string typeofRoom { get; set; }

    }
}
