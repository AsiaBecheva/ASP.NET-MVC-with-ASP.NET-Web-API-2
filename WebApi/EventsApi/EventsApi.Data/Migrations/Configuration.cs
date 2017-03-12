namespace EventsApi.Data.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Context context)
        {
            if (!context.Events.Any())
            {
                List<Event> events = new List<Event>();

                for (int i = 0; i < 20; i++)
                {
                    var ev = new Event()
                    {
                        Topic = "Topic - " + i,
                        HeldOn = DateTime.Now,
                        Description = "Rock YOUR Code with Visual Studio Live! (VSLive!™) in 2017. First up? Fabulous Las Vegas, where developers, software architects, engineers, designers and more will convene for five days of unbiased and cutting-edge education on the Microsoft Platform. Sharpen your skills in Visual Studio, ASP.NET, JavaScript, HTML5, Mobile, Database Analytics, and so much more. BONUS CONTENT: Modern Apps Live! will be a part of Visual Studio Live! Las Vegas, at no additional charge!"
                    };

                    events.Add(ev);
                }

                context.Events.AddOrUpdate(events.ToArray());
                context.SaveChanges();
            }
        }
    }
}
