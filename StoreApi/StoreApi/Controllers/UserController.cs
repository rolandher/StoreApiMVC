using Microsoft.AspNetCore.Mvc;
using StoreApi.Data;
using StoreApi.DTO;
using StoreApi.Model;

namespace StoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ToDoAPIDbContext dbContext;

        public UserController(ToDoAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
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

            dbContext.Add(newUser);
            await dbContext.SaveChangesAsync();
            return newUser;
        }              
                
    }
}
