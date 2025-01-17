﻿using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IGenaricRepository<T> where T : BaseEntity
    {
        //IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAll();
        //T Get(int id);
        Task<T> Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T model);
    }
}
