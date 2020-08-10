using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace KarcicegiYayinVeDagitim.Identity
{
    public class IdentityInitializer:CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            if (!context.Roles.Any(i=> i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Descripion = "admin rolü" };
                manager.Create(role);
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Descripion = "user rolü" };
                manager.Create(role);
            }
            if (!context.Users.Any(i => i.Name == "emrebahar"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "emre", Surname = "bahar", Email = "eb471652@gmail.com", UserName = "emrebhr", };
                _ = manager.Create(user, "123456");
                _ = manager.AddToRole(user.Id, "admin");
                _ = manager.AddToRole(user.Id, "user");
            }
            if (!context.Users.Any(i => i.Name == "farukAkdogan"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "Faruk", Surname = "Akdoğan", Email = "farukakdgn@gmail.com", UserName = "farukAkdogan", };
                _ = manager.Create(user, "123456");
                _ = manager.AddToRole(user.Id, "admin");
                _ = manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.Name == "bunyaminbahar"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "bunyamin", Surname = "bahar", Email = "bunyamin@gmail.com", UserName = "bunyaminn", };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "user");
            }


            base.Seed(context);
        }
    }
}