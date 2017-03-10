namespace WebSite.Data.Migrations
{
    using Infrastructure.Constants;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        private const string adminRoleName = "Administrator";
        private const string adminPassword = "mySecretPass";

        protected override void Seed(Context context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<User>(new UserStore<User>(context));

            if (!roleManager.RoleExists(adminRoleName))
            {
                var role = new IdentityRole()
                {
                    Name = adminRoleName
                };
                roleManager.Create(role);

                var user = new User()
                {
                    UserName = "asya@gmail.com",
                    Email = "asya@gmail.com"
                };

                IdentityResult createUserResult = userManager.Create(user, adminPassword);
                if (createUserResult.Succeeded)
                {
                    userManager.AddToRole(user.Id, adminRoleName);
                }
            }
        

        Article[] articles = new Article[]
            {
                new Article()
                {
                    Image = new Image()
                    {
                       CreatedOn = DateTime.UtcNow,
                       OriginalFileName = "FirstImg",
                       SystemFileName = "FirstImg",
                       Location = PathConstants.ArticlesImagePath
                    },
                    CreatedOn = DateTime.UtcNow,
                    Title = "Basic goals of computer programming",
                    Content = "When you are planning to create a computer program you should: Ensure your program fulfills the need it is addressing. Ensure that people can easily use your program. Ensure that it is easy to understand, fix, and improve your program without a major time investment."
                },
                new Article()
                {
                    Image = new Image()
                    {
                       CreatedOn = DateTime.UtcNow,
                       OriginalFileName = "ThirdImg",
                       SystemFileName = "ThirdImg",
                       Location = PathConstants.ArticlesImagePath
                    },
                    CreatedOn = DateTime.UtcNow,
                    Title = "Basic goals of computer programming",
                    Content = "When you are planning to create a computer program you should: Ensure your program fulfills the need it is addressing. Ensure that people can easily use your program. Ensure that it is easy to understand, fix, and improve your program without a major time investment."
                },
                new Article()
                {
                    Image = new Image()
                    {
                       CreatedOn = DateTime.UtcNow,
                       OriginalFileName = "SecondImg",
                       SystemFileName = "SecondImg",
                       Location = PathConstants.ArticlesImagePath
                    },
                    CreatedOn = DateTime.UtcNow,
                    Title = "Basic goals of computer programming",
                    Content = "When you are planning to create a computer program you should: Ensure your program fulfills the need it is addressing. Ensure that people can easily use your program. Ensure that it is easy to understand, fix, and improve your program without a major time investment."
                }
            };

            context.Articles.AddOrUpdate(articles);
            context.SaveChanges();
        }
    }
}
