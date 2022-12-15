using DormitoryManagement.Enitity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DormitoryManagement.Enitity.Concrete
{
   [Table("Block")]
   public class Block : IEntity
    {
   
        public int blockId { get; set; }
        public char blockNumber { get; set; }
  
    }
}
