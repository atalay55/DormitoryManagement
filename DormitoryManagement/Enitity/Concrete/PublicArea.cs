using DormitoryManagement.Enitity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DormitoryManagement.Enitity.Concrete
{

   
    public class PublicArea: IEntity
    {
        [Key]
        public int idOfMaterial { get; set; }
        public int priceOfMaterials { get; set; }
        public int blockNumberId { get; set; }

    }
}
