using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDressService
    {
        IResult Create(Dress dress);

        IDataResult<List<Dress>> GetAll();
        IDataResult <Dress> GetByDressId(int id); 
        IDataResult<List<Dress>> GetAllByColorId(int colorId);
        IDataResult<List<Dress>> GetAllByStyleId(int styleId);
        IDataResult<List<Dress>> GetAllBySizeId(int SizeId);
        IDataResult<List<Dress>> GetAllByLengthId(int LengthId);
        IDataResult<List<Dress>> GetByUnitPrice(double min, double max);

        IDataResult<List<DressDetailDto>> GetDressDetail();

    }
}
