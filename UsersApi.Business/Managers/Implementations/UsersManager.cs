using System;
using System.Collections.Generic;
using System.Text;
using UsersApi.Business.Managers.Interfaces;
using UsersApi.Common;
using UsersApi.DataAccess.DataAccess.Interfaces;

namespace UsersApi.Business.Managers.Implementations
{
    public class UsersManager : IUsersManager
    {
        private IUsersDataAccess _UsersDataAccess;

        public UsersManager(IUsersDataAccess usersDataAccess)
        {
            _UsersDataAccess = usersDataAccess;
        }

        public User CreateUser(User obj)
        {
            return _UsersDataAccess.CreateUser(obj);
        }

        public void Delete(string id)
        {
            _UsersDataAccess.Delete(id);
        }

        public List<User> GetUsers()
        {
            return _UsersDataAccess.GetUsers();
        }

        public User UpdateUser(string id, User obj)
        {
            obj.Id = id;

            return _UsersDataAccess.UpdateUser(obj);
        }
    }
}