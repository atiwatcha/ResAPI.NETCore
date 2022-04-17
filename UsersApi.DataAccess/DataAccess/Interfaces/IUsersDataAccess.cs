using System;
using System.Collections.Generic;
using System.Text;
using UsersApi.Common;

namespace UsersApi.DataAccess.DataAccess.Interfaces
{
    public interface IUsersDataAccess
    {
        List<User> GetUsers();

        User CreateUser(User obj);

        User UpdateUser(User obj);

        void Delete(string id);
    }
}