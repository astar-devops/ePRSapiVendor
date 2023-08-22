using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using ePRS_VendorAPI.Models;

namespace ePRS_VendorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDataController : ControllerBase
    {
        private readonly EPrsVendorContext _context;

        public UserDataController(EPrsVendorContext context)
        {
            _context = context;
        }

        [HttpGet("{vendorID}")]
        public async Task<ActionResult<List<TblLogin>>> GetAllUserData(int vendorID)
        {
            var result = await _context.TblLogins.FromSqlRaw($"spVendorLoginInsertNew {vendorID}").ToArrayAsync();
            return Ok(result);

        }


        [HttpPost("senddata")]
        public async Task<ActionResult<List<TblLogin>>> PostAllUserData()
        {
            var result = await _context.TblLogins.FromSqlRaw("spVendorLoginInsertNew").ToListAsync();
            return Ok(result);
        }

    } 
}
