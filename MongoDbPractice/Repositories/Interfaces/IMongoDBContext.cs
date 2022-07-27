using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbPractice.Repositories.Interfaces
{
    public interface IMongoDBContext
    {
        public IMongoCollection<T> GetCollection<T>(string name);
    }
}
