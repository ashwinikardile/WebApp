namespace ContactWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactWeb.Models.ContactWebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ContactWeb.Models.ContactWebContext";
        }

        protected override void Seed(ContactWeb.Models.ContactWebContext context)
        {
			//a3ea21eb-82fa-4895-9d2d-5de5334005fc
			//f698f17b-d792-4f24-bb25-3f4ce78bb5c3
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			context.Contacts.AddOrUpdate(
				p => p.Id,
				new Models.Contact
				{
					Id = 1,
					birthday = new DateTime(1920, 01, 20),
					city = "Chicago"
									,
					Email = "doc.mccoy@starfleet.com",
					FirstName = "DeForest",
					LastName = "Kelley"
									,
					contactPrim = "123-456-7890",
					contactSec = "234-567-8901",
					State = "IL"
									,
					streetAddress1 = "Sickbay",
					streetAddress2 = "Starship Enterprise NCC-1701"
									,
					UserId = new Guid("a3ea21eb-82fa-4895-9d2d-5de5334005fc")
									,
					Zip = "98765"
				}
				, new Models.Contact
				{
					Id = 2,
					birthday = new DateTime(1920, 03, 03),
					city = "New York"
									,
					Email = "i.beam.you.up@starfleet.com",
					FirstName = "James",
					LastName = "Doohan"
									,
					contactPrim = "345-678-9012",
					contactSec = "456-789-0123",
					State = "NY"
									,
					streetAddress1 = "Engineering",
					streetAddress2 = "Starship Enterprise NCC-1701"
									,
					UserId = new Guid("a3ea21eb-82fa-4895-9d2d-5de5334005fc")
									,
					Zip = "87654"
				}
				, new Models.Contact
				{
					Id = 3,
					birthday = new DateTime(1931, 03, 26),
					city = "Los Angeles"
									,
					Email = "its.only.logic@starfleet.com",
					FirstName = "Leonard",
					LastName = "Nimoy"
									,
					contactPrim = "987-654-3210",
					contactSec = "876-543-2109",
					State = "CA"
									,
					streetAddress1 = "Science Station 1",
					streetAddress2 = "Starship Enterprise NCC-1701"
									,
					UserId = new Guid("f698f17b-d792-4f24-bb25-3f4ce78bb5c3")
									,
					Zip = "76543-2109"
				}
				, new Models.Contact
				{
					Id = 4,
					birthday = new DateTime(1931, 03, 22),
					city = "Riverside"
									,
					Email = "the.captain@starfleet.com",
					FirstName = "William",
					LastName = "Shatner"
									,
					contactPrim = "765-432-1098",
					contactSec = "654-321-0987",
					State = "IA"
									,
					streetAddress1 = "The Bridge",
					streetAddress2 = "Starship Enterprise NCC-1701"
									,
					UserId = new Guid("f698f17b-d792-4f24-bb25-3f4ce78bb5c3")
									,
					Zip = "65432-0123"
				}
			);
		}
	}
}
