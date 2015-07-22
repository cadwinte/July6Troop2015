﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace Day_10_Project_ASP.NET_IV._1.Models
{
    public interface IGenericRepository : IDisposable
    {
        void Add<T>(T entityToCreate) where T : class;
        void Delete<T>(params object[] keyValues) where T : class;
        void Dispose();
        T Find<T>(params object[] keyValues) where T : class;
        IQueryable Query(string entityTypeName);
        IQueryable<T> Query<T>() where T : class;
        void SaveChanges();
        IEnumerable<T> SqlQuery<T>(string sql, params object[] parameters);
    }
}
