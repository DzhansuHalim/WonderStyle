using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStyleService
    {
        IResult Create(Style style); 

        IDataResult<List<Style>> GetAll();
        IDataResult<Style> GetByStyleId(int id);


    }
}
