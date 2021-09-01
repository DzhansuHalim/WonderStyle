using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sell : IEntity
    {
        public int SellId { get; set; }
        public int DressId { get; set; }
        public int CustomerId { get; set; }
        public DateTime SellDate { get; set; }
    }
}
