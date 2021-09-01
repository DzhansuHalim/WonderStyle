﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract.Repository
{
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        //CRUD

        void Create(T entity);
        List<T> GetAll( Expression<Func<T,bool>> filter = null );
        T Get(Expression<Func<T, bool>> filter);
        void Update(T entity);
        void Delete(T entity);
    }
}
