﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.contracts
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> Get(int id);
        IQueryable<T> GetQuery();
        Task<IReadOnlyList<T>> GetAll();
        Task<bool> Exist(int id);
        Task<T> Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}

