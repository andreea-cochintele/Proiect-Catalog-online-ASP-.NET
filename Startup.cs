﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using catalogv6.Models;

[assembly: OwinStartupAttribute(typeof(catalogv6.Startup))]
namespace catalogv6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateAdminAndUserRoles();
        }
        private void CreateAdminAndUserRoles()
        {
            var ctx = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(ctx));
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(ctx));

            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                var user = new ApplicationUser();
                user.UserName = "admin@admin.com";
                user.Email = "admin@admin.com";
                var adminCreated = userManager.Create(user, "admin1234.C");
                if (adminCreated.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Admin");
                }

            }

            if (!roleManager.RoleExists("Student"))
            {
                var role = new IdentityRole();
                role.Name = "Student";
                roleManager.Create(role);

                var user1 = new ApplicationUser();
                user1.UserName = "student@student.com";
                user1.Email = "student@student.com";
                var studentCreated = userManager.Create(user1, "student1234.C");
                if (studentCreated.Succeeded)
                {
                    userManager.AddToRole(user1.Id, "Student");
                }
            }

            if (!roleManager.RoleExists("Teacher"))
            {
                var role = new IdentityRole();
                role.Name = "Teacher";
                roleManager.Create(role);

                var user2 = new ApplicationUser();
                user2.UserName = "teacher@teacher.com";
                user2.Email = "teacher@teacher.com";
                var teacherCreated = userManager.Create(user2, "teacher1234.C");
                if (teacherCreated.Succeeded)
                {
                    userManager.AddToRole(user2.Id, "Teacher");
                }
            }
        }
    }
}
