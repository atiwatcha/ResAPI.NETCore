using Microsoft.AspNetCore.Mvc;
using UsersApi.Business.Managers.Interfaces;
using UsersApi.Mappers;
using UsersApi.Models;

namespace UsersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUsersManager _UsersManager;

        public UsersController(IUsersManager usersManager)
        {
            _UsersManager = usersManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_UsersManager.GetUsers());
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(UserItem user)
        {
            var userItem = UsersMapper.MapToCommon(user);

            var result = _UsersManager.CreateUser(userItem);

            var userObject = UsersMapper.MapToDto(result);

            return Ok(userObject);
        }

        [Route("{id}")]
        [HttpPatch]
        public ObjectResult Update(string id, UserItem user)
        {
            var userItem = UsersMapper.MapToCommon(user);

            var result = _UsersManager.UpdateUser(id, userItem);

            var userObject = UsersMapper.MapToDto(result);

            return Ok(userObject);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(string id)
        {
            _UsersManager.Delete(id);

            return Ok(id);
        }
    }
}