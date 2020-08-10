using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarcicegiYayinVeDagitim.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public string Descripion { get; set; }
        public ApplicationRole()
        {

        }
        public ApplicationRole(string rolname , string description)
        {
            this.Descripion = description;
        }
    }
}