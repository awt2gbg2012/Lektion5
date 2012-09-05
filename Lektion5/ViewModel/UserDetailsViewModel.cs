using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion5.Model;

namespace Lektion5.ViewModel
{
    public class UserDetailsViewModel
    {
        public User User { get; set; }
        public List<Post> Posts { get; set; }
    }
}