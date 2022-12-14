using DependencyInjection.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjection.Controllers
{
    public class UserController : Controller
    {
        readonly IUserMasterRepository userRepository;
        public UserController(IUserMasterRepository repository)
        {
            this.userRepository = repository;
        }
        // GET: User
        public ActionResult Index()
        {
            var data = userRepository.GetAll();
            return View(data);
        }
    }
}