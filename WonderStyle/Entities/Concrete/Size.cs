using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Size : IEntity
    {
        public int SizeId { get; set; }
        public string SizeName { get; set; }
    }
}
