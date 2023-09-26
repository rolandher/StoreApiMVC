using System.ComponentModel.DataAnnotations;

namespace StoreApi.DTO
{
    public class RegisterUserDTO
    {

        [Required] public string UserName { get; set; } 

        [Required] public string UserLastName { get; set; } 

        [Required] public string UserPassword { get; set; } 

        [Required] public string UserEmail { get; set; } 

        [Required] public string UserRole { get; set; }

        public RegisterUserDTO( string userName, string userLastName, string userPassword, string userEmail, string userRole)
        {
            UserName = userName;
            UserLastName = userLastName;
            UserPassword = userPassword;
            UserEmail = userEmail;
            UserRole = userRole;
        }

        public RegisterUserDTO()
        {
        }
    }
}
