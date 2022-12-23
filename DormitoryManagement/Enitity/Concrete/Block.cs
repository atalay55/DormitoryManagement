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
   
        [Key]
        public int blockId { get; set; }
        public char blockName { get; set; }
        public int numberOfMaterial { get; set; }
        public int numberOfStudents { get; set; }

    }
}
