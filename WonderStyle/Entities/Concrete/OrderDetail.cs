using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class OrderDetail : IEntity
    {
        
        public int OrderId { get; set; }
        [Key]
        public int DressId { get; set; }
        public int Quantity { get; set; }
    }
}
