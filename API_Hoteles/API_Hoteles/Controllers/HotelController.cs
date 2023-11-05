using API_Hoteles.Models;
using API_Hoteles.Models.DTO;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public HotelController(AplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var HotelList = await _context.Hotels.ToListAsync();
                var HotelListDTO = _mapper.Map<IEnumerable<HotelDTO>>(HotelList);
                return Ok(HotelListDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var Hotel = await _context.Hotels.FindAsync(id);
                if (Hotel == null)
                {
                    return NotFound();
                }
                var HotelDTO = _mapper.Map<HotelDTO>(Hotel);
                return Ok(HotelDTO);

            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
