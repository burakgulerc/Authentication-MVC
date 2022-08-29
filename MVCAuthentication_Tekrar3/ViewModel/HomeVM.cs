using MVCAuthentication_Tekrar3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthentication_Tekrar3.ViewModel
{
    public class HomeVM
    {
        public AppUser AppUser { get; set; }
        public List<AppUser> AppUsers { get; set; }

    }
}