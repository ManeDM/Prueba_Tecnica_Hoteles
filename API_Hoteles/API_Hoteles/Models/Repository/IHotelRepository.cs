namespace API_Hoteles.Models.Repository
{
    public interface IHotelRepository
    {
        Task<List<Hotel>> GetListHotels();
        Task<Hotel> GetHotelById(int id);
    }
}
