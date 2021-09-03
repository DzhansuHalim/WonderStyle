using Business.Abstract;
using Business.Constants;
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
            if(dress.DressName.Length < 2)
            {
                return new ErrorResult(Messages.DressNameInvalid);
            }

            _dressDal.Create(dress);
            return new SuccessResult(Messages.DressAdded);    
        }

        public IDataResult<List<Dress>> GetAll()
        {
            return new DataResult<List<Dress>>(_dressDal.GetAll(),true,Messages.ListedDresses);
        }

        public IDataResult<List<Dress>> GetAllByColorId(int colorId)
        {
            return new DataResult<List<Dress>>(_dressDal.GetAll(p => p.ColorId == colorId));
        }

        public IDataResult<List<Dress>> GetAllByLengthId(int lengthId)
        {
            return _dressDal.GetAll(p => p.LengthId == lengthId);
        }

        public IDataResult<List<Dress>> GetAllBySizeId(int sizeId)
        {
            return _dressDal.GetAll(p => p.SizeId == sizeId);
        }

        public IDataResult<List<Dress>> GetAllByStyleId(int styleId)
        {
            return _dressDal.GetAll(p => p.StyleId == styleId);
        }

        public IDataResult<List<Dress>> GetByUnitPrice(double min, double max)
        {
            return _dressDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max);
        }

        public IDataResult<List<DressDetailDto>> GetDressDetail()
        {
            return _dressDal.GetDressDetails();
        }
    }
}
