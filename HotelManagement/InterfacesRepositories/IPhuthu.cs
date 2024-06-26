﻿using HotelManagement.Models;

namespace HotelManagement.InterfacesRepositories
{
    public interface IPhuthuRepository
    {
        Task<List<Phuthu>> GetAllPhuthusAsync();
        Task<Phuthu> GetPhuthuByIdAsync(double id);
        Task AddPhuthuAsync(Phuthu phuthu);
        Task UpdatePhuthuAsync(Phuthu phuthu);
        Task DeletePhuthuAsync(double id);
        Task<bool> PhuthuExistsAsync(double id);
        Task<Phuthu> GetFirstPhuthuAsync();
    }

}
