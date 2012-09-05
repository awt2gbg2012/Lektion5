using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion5.Model;

namespace Lektion5.ViewModel
{
    public class UserListViewModel
    {
        public List<User> Users { get; set; }
        public int CurrentPage { get; set; }
        public int FirstPage { get; set; }
        public int LastPage { get; set; }
    }
}