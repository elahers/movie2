using Cinema.Data;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;


namespace Cinema.Controllers
{
    public class ReserveController : Controller
    {
        private readonly IEmailSender _emailSender;
        private ApplicationDbContext db = null;
        public ReserveController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
            db = new ApplicationDbContext();
        }
        public IActionResult Search(string cinemaname, string moviename, DateTime date)
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
