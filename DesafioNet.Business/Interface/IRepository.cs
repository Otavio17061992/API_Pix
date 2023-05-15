using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioNet.Business.Models;

namespace DesafioNet.Business.Interface
{
    public interface IRepository<TEntity>: IDisposable where TEntity : Entity
    {
        void Adicionar(TEntity entity);
    }
}
