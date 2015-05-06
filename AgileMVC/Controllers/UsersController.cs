using AgileMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgileMVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersRepository _repository;
        public UsersController(IUsersRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index(int id)
        {
            var model = _repository.GetUser(id);
            return View(model);
        }
    }
}