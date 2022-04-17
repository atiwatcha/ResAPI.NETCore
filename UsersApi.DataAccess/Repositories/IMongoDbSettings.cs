using System;
using System.Collections.Generic;
using System.Text;

namespace UsersApi.DataAccess.Repositories
{
    public interface IMongoDbSettings
    {
        string DbName { get; set; }
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
    }
}