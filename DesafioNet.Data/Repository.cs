using DesafioNet.Business.Interface;
using DesafioNet.Business.Models;
using DesafioNet.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioNet.Data
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity,new()
    {
        private readonly SqlContext _sqlContext;


        public Repository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void Adicionar(TEntity entity)
        {
            _sqlContext.Set<TEntity>().Add(entity);
            _sqlContext.SaveChanges();
        }

        public void Dispose()
        {
            _sqlContext?.Dispose();
        }
    }
}
