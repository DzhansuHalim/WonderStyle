using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDressDal : IDressDal
    {
        List<Dress> _dresses;

        public InMemoryDressDal()
        {
            _dresses = new List<Dress>
            {
                new Dress
                { 
                    DressId = 1, 
                    ColorId = 1, 
                    SizeId= 1, 
                    StyleId = 1, 
                    LengthId = 1, 
                    DressName = "Floral Tunic V-Neckline Knee-Length A-line Dress", 
                    UnitPrice = 10.59, 
                    UnitsInStock = 10 
                }
            };
        }

        public void Create(Dress dress)
        {
            _dresses.Add(dress);
        }

        public void Delete(Dress dress)
        {
            Dress dressToDelete =_dresses.SingleOrDefault(d => d.DressId == dress.DressId);

            _dresses.Remove(dressToDelete);
        }

        public List<Dress> GetAll()
        {
            return _dresses;
        }

        public void Update(Dress dress)
        {
            Dress dressToUpdate = _dresses.SingleOrDefault(d => d.DressId == dress.DressId);
            dressToUpdate.ColorId = dress.ColorId;
            dressToUpdate.DressName = dress.DressName;
            dressToUpdate.LengthId = dress.LengthId;
            dressToUpdate.SizeId = dress.SizeId;
            dressToUpdate.StyleId = dress.StyleId;
            dressToUpdate.UnitPrice = dress.UnitPrice;
            dressToUpdate.UnitsInStock = dress.UnitsInStock;
        }



        public List<Dress> GetByColor(int colorId)
        {
            return _dresses.Where(p => p.ColorId == colorId).ToList();
        }

        public List<Dress> GetAll(Expression<Func<Dress, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Dress Get(Expression<Func<Dress, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<DressDetailDto> GetDressDetails()
        {
            throw new NotImplementedException();
        }
    }
}
