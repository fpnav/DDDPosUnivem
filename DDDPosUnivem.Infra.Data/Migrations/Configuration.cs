namespace DDDPosUnivem.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration 
        : DbMigrationsConfiguration<DDDPosUnivem.Infra.Data.Context.DDDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //DANGER - somente em ambiente de desenvolvimento
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DDDPosUnivem.Infra.Data.Context.DDDContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
