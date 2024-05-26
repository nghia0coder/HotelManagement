// StaffController.cs
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Filters;
using Microsoft.AspNetCore.Http;  // Add this using statement
using static HotelManagement.Models.AuthorizationModel;

namespace HotelManagement.Controllers
{
    [CustomAuthorization(UserRole.Staff)]
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
