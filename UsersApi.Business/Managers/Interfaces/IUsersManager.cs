using System;
using System.Collections.Generic;
using System.Text;
using UsersApi.Common;

namespace UsersApi.Business.Managers.Interfaces
{
    public interface IUsersManager
    {
        List<User> GetUsers();

        User CreateUser(User obj);

        User UpdateUser(string id, User obj);

        void Delete(string id);
    }
}