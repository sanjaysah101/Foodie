using Foodie.Models;
using Microsoft.AspNetCore.Mvc;

namespace Foodie.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PartialBooking()
        {
            return PartialView("~/Views/Shared/Frontend/_Booking.cshtml");
        }
        [HttpPost]
        public async Task<ContentResult> Booking(Booking newBooking)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Api<Booking> api = new Api<Booking>();
                    var res = await api.Send(newBooking, "Booking");
                    if (res.Success)
                    {
                        return Content("<span class='alert alert-success'>Booking Successfull</span>");
                    }
                    return Content("<span class='alert alert-warning'>Something went wrong Success</span>");
                }
                return Content("<span class='alert alert-warning'>Invalid Data</span>");
            }
            catch (Exception e)
            {
                return Content("<span class='alert alert-danger'>something went wrong...</span>");
            }
        }
    }
}
