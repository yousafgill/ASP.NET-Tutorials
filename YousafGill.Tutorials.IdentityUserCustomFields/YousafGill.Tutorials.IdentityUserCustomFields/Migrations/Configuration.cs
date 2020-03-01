namespace YousafGill.Tutorials.IdentityUserCustomFields.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<YousafGill.Tutorials.IdentityUserCustomFields.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "YousafGill.Tutorials.IdentityUserCustomFields.Models.ApplicationDbContext";
        }

        protected override void Seed(YousafGill.Tutorials.IdentityUserCustomFields.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
