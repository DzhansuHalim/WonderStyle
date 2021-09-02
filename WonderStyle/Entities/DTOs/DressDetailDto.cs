using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class DressDetailDto: IDto
    {
        public int DressId { get; set; }
        public string ColorName { get; set; }
        public string StyleName { get; set; }
        public string SizeName { get; set; }
        public string DressName { get; set; }
        public double UnitPrice { get; set; } 
    }
}
