namespace DATA_98_DESKTOP_MK2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DATA_98_DESKTOP_MK2.Contexts.RefuseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DATA_98_DESKTOP_MK2.Contexts.RefuseContext";
        }

        protected override void Seed(DATA_98_DESKTOP_MK2.Contexts.RefuseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
