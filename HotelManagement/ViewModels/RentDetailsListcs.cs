using Microsoft.EntityFrameworkCore;
using HotelManagement.Models;

namespace HotelManagement.ViewModels
{
    public class RentDetailsList
    {
        public Phieuthue phieuthue { get; set; }
        public List<Khachhang> khachhangs { get; set; }
    }

}
