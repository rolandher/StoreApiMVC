using StoreApi.Model.ProductEntity;
using StoreApi.Model.UserEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApi.Model.BranchEntity
{
    public class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Products is required")]
        public String ProductsId { get; set; }

        [Required(ErrorMessage = "Users is required")]
        public String UsersId { get; set; }
    }
}
