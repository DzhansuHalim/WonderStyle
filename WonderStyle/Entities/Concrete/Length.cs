using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Length : IEntity
    {
        public int LengthId { get; set; }
        public string LengthName { get; set; }
    }
}
