using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDressService
    {
        void Create(Dress dress);

        List<Dress> GetAll();
        List<Dress> GetAllByColorId(int colorId);
        List<Dress> GetAllByStyleId(int styleId);
        List<Dress> GetAllBySizeId(int SizeId);
        List<Dress> GetAllByLengthId(int LengthId);
        List<Dress> GetByUnitPrice(double min, double max);

        List<DressDetailDto> GetDressDetail();

    }
}
