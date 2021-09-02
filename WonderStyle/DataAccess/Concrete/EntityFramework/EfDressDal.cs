using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDressDal : EfEntityRepositoryBase<Dress, WonderStyleContext>, IDressDal
    {
        public List<DressDetailDto> GetDressDetails()
        {
            using(WonderStyleContext context = new WonderStyleContext())
            {
                var result = from d in context.Dresses
                             join c in context.Colors
                             on d.ColorId equals c.ColorId
                             join s in context.Sizes
                             on d.SizeId equals s.SizeId
                             join style in context.Styles
                             on d.StyleId equals style.StyleId
                             select new DressDetailDto
                             {
                                 DressId = d.DressId,
                                 ColorName = c.ColorName,
                                 DressName = d.DressName,
                                 UnitPrice = d.UnitPrice,
                                 StyleName = style.StyleName,
                                 SizeName = s.SizeName
                             };
                return result.ToList();
            }
        }
    }
}
