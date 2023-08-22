using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using ePRS_VendorAPI.Models;
using Microsoft.Extensions.Configuration;

namespace ePRS_VendorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly EPrsVendorContext _context;
        
        public LoginController(EPrsVendorContext context)
        {
            _context = context;
        }

        [HttpGet("vendor")]
        public async Task<ActionResult<List<TblLogin>>> GetVendorData(int vendorID, string password, string erpNo)
        {


            var result = await _context.Database.ExecuteSqlRawAsync($"spAdminLoginSelectbyLoginID {vendorID}, {password}");
            return Ok(result);
        }



    }
}