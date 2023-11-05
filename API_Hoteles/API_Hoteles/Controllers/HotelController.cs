using API_Hoteles.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Hoteles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public HotelController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var HotelList = await _context.Hotels.ToListAsync();
                return Ok(HotelList);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
