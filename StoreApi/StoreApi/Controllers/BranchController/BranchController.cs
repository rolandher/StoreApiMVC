using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.DTO.BranchDTO;
using StoreApi.Model.BranchEntity;

namespace StoreApi.Controllers.BranchController
{
    [ApiController]
    [Route("api/[controller]")]
    public class BranchController : ControllerBase
    {

        private readonly ApplicationDbContext _dbContext;

        public BranchController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetAllBranches")]

        public async Task<ActionResult<List<Branch>>> Get()
        {
            return await _dbContext.Branch.ToListAsync();
        }

        [HttpPost(Name = "RegisterBranch")]

        public async Task<Branch> RegisterBranch(RegisterBranchDTO branchDTO)
        {
            var newBranch = new Branch();
            newBranch.Name = branchDTO.Name;
            newBranch.Location = branchDTO.Location;
            newBranch.ProductsId = branchDTO.ProductsId;
            newBranch.UsersId = branchDTO.usersId;            
            
            _dbContext.Add(newBranch);
            await _dbContext.SaveChangesAsync();
            return newBranch;
                       
        }       
                
    }

}
