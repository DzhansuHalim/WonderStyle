using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DressManager : IDressService
    {
        //business rules

        IDressDal _dressDal;

        public DressManager(IDressDal dressDal)
        {
            _dressDal = dressDal;
        }

        public List<Dress> GetAll()
        {
            return _dressDal.GetAll();
        }
    }
}
