using MinhaAPI.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaAPI.Business.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
    }
}
