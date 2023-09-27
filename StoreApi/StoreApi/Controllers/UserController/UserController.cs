using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.DTO.UserDTO;
using StoreApi.Model.UserEntity;

namespace StoreApi.Controllers.UserController
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ApplicationDbContext _dbContext;

        public UserController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetAllUsers")]
        public async Task<ActionResult<List<User>>> Get()
        {
            return await _dbContext.User.ToListAsync();
        }

        [HttpPost(Name = "RegisterUser")]
        public async Task<User> Post(RegisterUserDTO user)
        {
            var newUser = new User();
            newUser.Name = user.UserName;
            newUser.LastName = user.UserLastName;
            newUser.Email = user.UserEmail;
            newUser.Password = user.UserPassword;
            newUser.Role = user.UserRole;

            _dbContext.Add(newUser);
            await _dbContext.SaveChangesAsync();
            return newUser;
        }    
      


       

    }
}
