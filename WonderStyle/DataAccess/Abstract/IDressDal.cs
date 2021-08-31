using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IDressDal
    {
        //CRUD

        void Create(Dress dress);
        List<Dress> GetAll();
        void Update(Dress dress);
        void Delete(Dress dress);


        List<Dress> GetByColor(int colorId);




    }
}
