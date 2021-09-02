using Business.Abstract;
using Core.Utilities.Results;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IResult Create(Dress dress)
        {
            _dressDal.Create(dress);
            return new Result();
        }

        public List<Dress> GetAll()
        {
            return _dressDal.GetAll();
        }

        public List<Dress> GetAllByColorId(int colorId)
        {
            return _dressDal.GetAll(p => p.ColorId == colorId);
        }

        public List<Dress> GetAllByLengthId(int lengthId)
        {
            return _dressDal.GetAll(p => p.LengthId == lengthId);
        }

        public List<Dress> GetAllBySizeId(int sizeId)
        {
            return _dressDal.GetAll(p => p.SizeId == sizeId);
        }

        public List<Dress> GetAllByStyleId(int styleId)
        {
            return _dressDal.GetAll(p => p.StyleId == styleId);
        }

        public List<Dress> GetByUnitPrice(double min, double max)
        {
            return _dressDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max);
        }

        public List<DressDetailDto> GetDressDetail()
        {
            return _dressDal.GetDressDetails();
        }
    }
}
