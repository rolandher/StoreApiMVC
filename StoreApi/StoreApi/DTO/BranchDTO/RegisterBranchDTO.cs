using System.ComponentModel.DataAnnotations;

namespace StoreApi.DTO.BranchDTO
{
    public class RegisterBranchDTO
    {
        [Required] public string Name { get; set; }

        [Required] public string Location { get; set; }

        [Required] public String ProductsId { get; set; }

        [Required] public string usersId { get; set; }        
       

    }
}
