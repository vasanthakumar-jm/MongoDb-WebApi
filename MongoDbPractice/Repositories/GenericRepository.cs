using MongoDB.Driver;
using MongoDbPractice.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbPractice.Repositories
{

    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly IMongoDBContext _mongoContext;
        protected IMongoCollection<TEntity> _dbCollection { get; private set; }

        protected GenericRepository(IMongoDBContext context,string collection)
        {
            _mongoContext = context;
            _dbCollection = _mongoContext.GetCollection<TEntity>(collection);
        }
    }
}
