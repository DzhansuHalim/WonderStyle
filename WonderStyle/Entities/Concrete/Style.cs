using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Style: IEntity
    {
        public int StyleId { get; set; }
        public string StyleName { get; set; }
    }
}
