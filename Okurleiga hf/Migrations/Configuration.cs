namespace Okurleiga_hf.Migrations
{
    using Okurleiga_hf.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    //using Okurleiga_hf.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Okurleiga_hf.Context.ApartmentDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Okurleiga_hf.Context.ApartmentDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

           
            Employee e1 = new Employee()
            {
                FirstName = "Gunnar ��r",
                LastName = "J�nsson",
                SocialNumber = "112387 - 4354",
                Address = "Sunnubraut 8",
                City = "Akureyri",
                Zip = 600,
                Phone = "865-8969",
                DateStart = new DateTime(2018, 12, 08)
            };

            Employee e2 = new Employee()
            {
                FirstName = "P�tur",
                LastName = "Magnason",
                SocialNumber = "110377 - 4354",
                Address = "L�kjartorg 23",
                City = "Reykjav�k",
                Zip = 101,
                Phone = "777-5454",
                DateStart = new DateTime(2015, 10, 21)
            };

            Employee e3 = new Employee()
            {
                FirstName = "Gu�mundur Ingi",
                LastName = "P�lsson",
                SocialNumber = "010187 - 3456",
                Address = "Kr�kam�ri 76",
                City = "Gar�ab�r",
                Zip = 210,
                Phone = "863-5465",
                DateStart = new DateTime(2017, 12, 08)
            };

            context.Employees.AddOrUpdate(
                e => new { e.FirstName, e.LastName },
                e1,
                e2,
                e3               
                );

            context.SaveChanges();                    
            
            ApartmentOwner ao1 = new ApartmentOwner()
            {                
                CompanyName = "Lofti�",
                ContactFirstName = "Sigur�ur",
                ContactLastName = "��rsson",
                Address = "K�llunarklettsvegur 2",
                City = "Reykjav�k",
                Zip = 201,
                Email = "siggi@loftid.is",
                Phone = "571-3467",
                SocialNumber = "511299-5489"
            };

            ApartmentOwner ao2 = new ApartmentOwner()
            {                
                CompanyName = "Byggjum saman",
                ContactFirstName = "Stef�n",
                ContactLastName = "��rsson",
                Address = "Sk�lavegur 2",
                City = "Reykjav�k",
                Zip = 201,
                Email = "stebbi@byggjum.is",
                Phone = "571-1007",
                SocialNumber = "125812-5969"
            };

            ApartmentOwner ao3 = new ApartmentOwner()
            {
                CompanyName = "DHL",
                ContactFirstName = "A�alhei�ur",
                ContactLastName = "Gunnlaugsd�ttir",
                Address = "Brj�nsholt 4",
                City = "K�pavogur",
                Zip = 241,
                Email = "adalheidur@dhl.is",
                Phone = "865-2365",
                SocialNumber = "254587-1254"
                
            };
                        
            context.SaveChanges();

            context.ApartmentOwners.AddOrUpdate(
                ao => ao.CompanyName,
                ao1,
                ao2,
                ao3
                );          

            Apartment a1 = new Apartment()
            {
                RegisteredAt = new DateTime(2018, 11, 03),
                Address = "Sk�lavegur 3",
                City = "Reykjav�k",
                Zip = 201,
                Bedroom = 3,
                Bathroom = 1,
                Size = 110,
                RentPrize = 180000,
                Available = true,
                RentType = "Langt�ma",
                Garage = false,
                Smoking = false,
                Pet = true,
                Type = "Parh�s",
                ApartmentOwner = ao2,                
            };

            Apartment a2 = new Apartment()
            {
                RegisteredAt = new DateTime(2018, 08, 03),
                Address = "Gar�atorg 3",
                City = "Keflav�k",
                Zip = 112,
                Bedroom = 5,
                Bathroom = 2,
                Size = 210,
                RentPrize = 280000,
                Available = false,
                RentType = "Langt�ma",
                Garage = true,
                Smoking = false,
                Pet = true,
                Type = "Einb�li",
                ApartmentOwner = ao3,                
            };

            Apartment a3 = new Apartment()
            {
                RegisteredAt = new DateTime(2019, 01, 03),
                Address = "Keldusk�gar 8",
                City = "Egilssta�ir",
                Zip = 700,
                Bedroom = 3,
                Bathroom = 1,
                Size = 150,
                RentPrize = 130000,
                Available = true,
                RentType = "Langt�ma",
                Garage = false,
                Smoking = false,
                Pet = false,
                Type = "Tv�b�li",
                ApartmentOwner = ao2
            };

            Apartment a4 = new Apartment()
            {
                RegisteredAt = new DateTime(2017, 10, 13),
                Address = "Gunnarsbraut 7",
                City = "Reykjav�k",
                Zip = 221,
                Bedroom = 2,
                Bathroom = 1,
                Size = 90,
                RentPrize = 110000,
                Available = false,
                RentType = "Skammt�ma",
                Garage = false,
                Smoking = false,
                Pet = false,
                Type = "Parh�s",
                ApartmentOwner = ao1,                
            };

            Apartment a5 = new Apartment()
            {
                RegisteredAt = new DateTime(2018, 11, 03),
                Address = "Sk�last�gur 21",
                City = "Njar�v�k",
                Zip = 301,
                Bedroom = 3,
                Bathroom = 1,
                Size = 130,
                RentPrize = 180000,
                Available = true,
                RentType = "Langt�ma",
                Garage = true,
                Smoking = false,
                Pet = false,
                Type = "Einb�li",
                ApartmentOwner = ao1,                
            };

            context.Apartments.AddOrUpdate(
                a => new { a.Address, a.City },
                a1,
                a2,
                a3,
                a4,
                a5
                );

            context.SaveChanges();

            Customer c1 = new Customer()
            {
                FirstName = "Sunna",
                LastName = "Gunnarsd�ttir",
                SocialNumber = "030489 - 4354",
                Email = "sunnarg@gmail.com",
                Phone = "867-3243",
                Apartment = a1
            };

            Customer c2 = new Customer()
            {
                FirstName = "Bj�rn",
                LastName = "J�nsson",
                SocialNumber = "0812879 - 5354",
                Email = "bjossi@kraftur.com",
                Phone = "867-3443",
                Apartment = a2
            };

            Customer c3 = new Customer()
            {
                FirstName = "��rey",
                LastName = "Har�ard�ttir",
                SocialNumber = "030869 - 2359",
                Email = "totag@simnet.is",
                Phone = "878-3289",
                Apartment = a3
            };

            Customer c4 = new Customer()
            {
                FirstName = "�skar ��r",
                LastName = "Hermansson",
                SocialNumber = "240490 - 4359",
                Email = "skari@gmail.com",
                Phone = "854-3243",
                Apartment = a4
            };

            context.Customers.AddOrUpdate(
                c => new { c.FirstName, c.LastName },
                c1,
                c2,
                c3,
                c4
                );

            context.SaveChanges();

            ApartmentIncident ai1 = new ApartmentIncident()
            {
                RegisterDate = new DateTime(2018, 01, 02),
                RegisterName = "Gunnar ��r J�nsson",
                IncidentInfo = "Bila�ur ofn inn� stofu",
                Status = "N�skr�ning",
                ContractorWhoFixed = "Gulli Byggir",
                Apartment = a1
            };
            context.ApartmentIncidents.AddOrUpdate(
                ai => ai.IncidentInfo,
                 ai1
                 );

            context.SaveChanges();
        }
    }
}
