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
            var lastPage = Repo.GetLastUserPage();
            var userDetails = Repo.GetUsers(id - 1, 10)
                                  .Select(u => new UserDetailsViewModel() { User = u, Posts = Repo.GetPostByUserID(u.UserID, 5) })
                                  .ToList(); // Den här logiken skulle vi vilja lägga i Model för att hålla Controller ren - hur gör vi det?
            var vm = new UserListViewModel() { UserDetails = userDetails, CurrentPage = id, FirstPage = 1, LastPage = lastPage };

            return View(vm);
        }

    }
}
