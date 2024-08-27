﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
        public interface IRepository<T, K> where T : class
        {
            T Add(T item);

            List<T> AddRange(List<T> items);

            bool Update(T item);

            bool UpdateTwoEntities(T item, K kitem, bool createItem = false);

            bool DeleteById(K id);

            bool Delete(T item);

            T GetById(K id);

            IQueryable<T> GetAll(bool includeSoftDeleted = false);
            Task<List<T>> Findlist();
            IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool includeSoftDeleted = false, params Expression<Func<T, object>>[] includes);
        }
    }
