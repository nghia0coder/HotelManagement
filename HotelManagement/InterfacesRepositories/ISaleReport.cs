using HotelManagement.Models;
using HotelManagement.ViewModels;

namespace HotelManagement.InterfacesRepositories
{
    public interface ISaleReport
    {
        Task<List<SaleReportViewModel>> GetSaleReportForMonthYear(int month);
    }
}
