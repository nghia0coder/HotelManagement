using Microsoft.EntityFrameworkCore;
using HotelManagement.Models;

namespace HotelManagement.Repositories
{
    public interface ILoaiPhongRepository
    {
        Task<Loaiphong> GetByIdAsync(int id);
        IQueryable<Loaiphong> GetAllAsync();
        Task AddAsync(Loaiphong loaiphong);
        Task UpdateAsync(Loaiphong loaiphong, int id);
        Task DeleteAsync(int Id);
        Task<List<string>> GetDistinctRoomTypesAsync();

    }
}
