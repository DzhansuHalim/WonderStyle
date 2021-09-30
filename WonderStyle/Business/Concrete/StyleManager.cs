using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Results.Concrete.DataRes;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class StyleManager : IStyleService
    {
        IStyleDal _styleDal;

        public StyleManager(IStyleDal styleDal)
        {
            _styleDal = styleDal;
        }

        public IResult Create(Style style)
        {
            IResult result = BusinessRules.Run(CheckIfStyleNameExists(style.StyleName));
            if (result != null)
            {
                _styleDal.Create(style);
                return new SuccessResult(Messages.DressAdded);
            }
            return new ErrorResult();
        }



        public IDataResult<List<Style>> GetAll()
        {
            return new SuccessDataResult<List<Style>>(_styleDal.GetAll(),"Styles are listed");
        }

        public IDataResult<Style> GetByStyleId(int id)
        {
            return new SuccessDataResult<Style>(_styleDal.Get(p => p.StyleId == id));
        }





        private IResult CheckIfStyleNameExists(string styleName)
        {
            var result = _styleDal.GetAll(d => d.StyleName == styleName).Any();
            if (result)
            {
                return new ErrorResult(Messages.DressNameAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
