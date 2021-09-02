using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Dress : IEntity
    {
        public int DressId { get; set; }
        public int ColorId { get; set; }
        public int StyleId { get; set; }
        public int LengthId { get; set; }
        public int SizeId { get; set; }

        public string DressName { get; set; }
        public int UnitsInStock { get; set; }
        public double UnitPrice { get; set; }


    }
}
