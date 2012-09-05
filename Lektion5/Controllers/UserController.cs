using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lektion5.Model.Repositories;
using Lektion5.ViewModel;

namespace Lektion5.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index(int id = 1)
        {
            Repository Repo = new Repository();
            var users = Repo.GetUsers(id - 1, 10);
            var lastPage = Repo.GetLastUserPage();
            var vm = new UserListViewModel() { Users = users, CurrentPage = id, FirstPage = 1, LastPage = lastPage };

            return View(vm);
        }

    }
}
