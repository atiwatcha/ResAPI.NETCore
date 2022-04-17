using System;
using System.Collections.Generic;
using System.Text;
using UsersApi.DataAccess.Repositories;

namespace UsersApi.DataAccess.Settings
{
    public class MongoDbSettings : IMongoDbSettings
    {
        public string DbName { get; set; }
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
    }
}