using Microsoft.EntityFrameworkCore;

namespace API_Hoteles.Models.Repository
{
    public class HotelRepository: IHotelRepository
    {
        private readonly AplicationDbContext _context;

        public HotelRepository(AplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<Hotel>> GetListHotels()
        {
            return await _context.Hotels.ToListAsync();
        }

        public async Task<Hotel> GetHotelById(int id)
        {
            return await _context.Hotels.FindAsync(id);
        }

    }
}
