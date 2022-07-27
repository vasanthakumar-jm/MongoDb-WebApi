using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbPractice.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity:class
    {
    }
}
