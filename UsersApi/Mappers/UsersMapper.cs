using UsersApi.Common;
using UsersApi.Models;

namespace UsersApi.Mappers
{
    public static class UsersMapper
    {
        public static User MapToCommon(UserItem obj)
        {
            if (obj == null)
            {
                return null;
            }

            return new User
            {
                Id = obj.Id,
                Name = obj.Name
            };
        }

        public static UserItem MapToDto(User obj)
        {
            if (obj == null)
            {
                return null;
            }

            return new UserItem
            {
                Id = obj.Id,
                Name = obj.Name
            };
        }
    }
}