using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController
    {
        IUserService _userService;
        UserMapper _userMapper;

        public UserController(IUserService userService, UserMapper userMapper)
        {
            _userService = userService;
            _userMapper = userMapper;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            User user = _userService.GetUser(id);

            if (user == null)
            {
                return NotFound();
            }


            UserDto UserDto = _userMapper.MapUserToUserDto(user);

            return Ok(UserDto);
        }

        [HttpGet]
        public IActionResult GetByRole(string role)
        {
            User user = _userService.GetUserByRole(role, out string message);

            if (user == null)
            {
                return NotFound();
            }


            UserDto UserDto = _userMapper.MapUserToUserDto(user);

            return Ok(UserDto);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] CreateUserRequest user)
        {


            User mappedUser = _userMapper.MapCreateUserRequestToUser(user);


            User? createdUser = _userService.CreateUser(mappedUser, out string message);

            if (createdUser == null)
            {
                return BadRequest(message);
            }

            UserDto CreatedCategoryDto = _userMapper.MapUserToUserDto(createdUser);
            return Ok(CreatedCategoryDto);
        }

        [HttpPost]
        public IActionResult UpdateUser([FromBody] UpdateUserRequest user)
        {
            User mappedUser = _userMapper.MapUpdateUserRequestToUser(user);

            User? UserUpdated = _userService.UpdateUser(mappedUser, out string message);

            if (UserUpdated is null)
            {
                return BadRequest(message);
            }

            UserDto UpdatedUserDto = _userMapper.MapUserToUserDto(UserUpdated);

            return Ok(UpdatedUserDto);
        }

        [HttpDelete]
        public IActionResult DeleteUser([FromBody] DeleteUserRequest user)
        {
            User mappedUser = _userMapper.MapDeleteUserRequestToCategory(user);

            bool UserDeleted = _userService.DeleteUser(mappedUser.Id, out string message);

            return Ok(UserDeleted);

        }
    }
}
