using Microsoft.EntityFrameworkCore;
using HotelManagement.Models;

namespace HotelManagement.InterfacesRepositories
{
    public interface ILoaiKhachRepository
    {
        Task<Loaikhach> GetByIdAsync(int id);
        IQueryable<Loaikhach> GetAllAsync();
        Task AddAsync(Loaikhach loaikhach);
        Task UpdateAsync(Loaikhach loaikhach);
        Task DeleteAsync(int Id);
        Task<List<string>> GetDistinctClientTypeAsync();

    }
}