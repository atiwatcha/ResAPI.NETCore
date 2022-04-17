using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsersApi.Common;
using UsersApi.DataAccess.DatabaseContexts;
using UsersApi.DataAccess.Repositories.Interfaces;

namespace UsersApi.DataAccess.Repositories.Implementations
{
    public class UsersRepository : IUsersRespository
    {
        private static List<User> _users = new List<User>();

        private IMongoCollection<User> _collection;

        public UsersRepository(IMongoDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DbName);

            _collection = database.GetCollection<User>(settings.CollectionName);
        }

        public User CreateUser(User obj)
        {
            obj.Id = Guid.NewGuid().ToString();
            obj.CreationDate = DateTime.Now;

            _collection.InsertOne(obj);

            return obj;
        }

        public void Delete(string id)
        {
            _collection.DeleteOne(x => x.Id == id);
        }

        public List<User> GetUsers()
        {
            return _collection.Find(_ => true).ToList();
        }

        public User UpdateUser(User obj)
        {
            _collection.ReplaceOne(x => x.Id == obj.Id, obj);

            return obj;
        }
    }
}