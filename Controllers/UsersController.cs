using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GlobalSoporte.NET.Models;
using GlobalSoporte.NET.DataAccess;

namespace GlobalSoporte.NET.Controllers
{
    public class UsersController : Controller
    {
        public static List<Users> usersList = new List<Users>();
        // GET: Users
        public ActionResult Index()
        {
            using (SoporteContext context = new SoporteContext())
            {
                usersList = context.Users.ToList();
            }
            return View(usersList);
        }
        //Obtener una lista de usuarios.
        public ActionResult GetUsersByID() 
        {
            return View();
        }

    }
}