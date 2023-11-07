using Microsoft.EntityFrameworkCore;

namespace API_Hoteles.Models.Repository
{
    public class HotelRepository : IHotelRepository
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

        public async Task DeleteHotel(Hotel hotel)
        {
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task<Hotel> AddHotel(Hotel hotel)
        {
            _context.Add(hotel);
            await _context.SaveChangesAsync();
            return hotel;
        }

        public async Task UpdateHotel(Hotel hotel)
        {
           var hotelValue = await _context.Hotels.FirstOrDefaultAsync(h => h.Id == hotel.Id);
            
            if (hotelValue != null)
            {
                hotelValue.Name = hotel.Name;
                hotelValue.Stars = hotel.Stars;
                hotelValue.Country = hotel.Country;
                hotelValue.City = hotel.City;
                hotelValue.Address = hotel.Address;
                hotelValue.Description = hotel.Description;

                await _context.SaveChangesAsync();
            }
        }
    }
}
