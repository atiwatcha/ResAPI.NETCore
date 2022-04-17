using System;
using System.Collections.Generic;
using System.Text;
using UsersApi.Common;
using UsersApi.DataAccess.DataAccess;
using UsersApi.DataAccess.DataAccess.Interfaces;
using UsersApi.DataAccess.Repositories.Interfaces;

namespace UsersApi.DataAccess.DataAccess.Implementations
{
    public class UsersDataAccess : IUsersDataAccess
    {
        private IUsersRespository _UsersRepository;

        public UsersDataAccess(IUsersRespository usersRepository)
        {
            _UsersRepository = usersRepository;
        }

        public User CreateUser(User obj)
        {
            return _UsersRepository.CreateUser(obj);
        }

        public void Delete(string id)
        {
            _UsersRepository.Delete(id);
        }

        public List<User> GetUsers()
        {
            return _UsersRepository.GetUsers();
        }

        public User UpdateUser(User obj)
        {
            return _UsersRepository.UpdateUser(obj);
        }
    }
}