namespace DAL.Migrations
{
    using DAL.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Net;
    using System.Security.Cryptography;
    using System.Xml.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.PostContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.PostContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            Random randommm = new Random();
            for (int i = 1; i <= 10; i++)
            {
                context.JobApply.AddOrUpdate(new Models.JobApply
                {
                    JId = i,
                    Name = Guid.NewGuid().ToString().Substring(0, 10),
                    Date = DateTime.Now,
                    NID = i + randommm.Next(1, 11),
                });
            }


        }
    }
}
