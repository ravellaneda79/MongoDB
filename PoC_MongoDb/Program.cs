using System;
using System.Linq;
using MongoCRUD;
using MongoDbAccess;

namespace PoC_MongoDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var personDB = new PersonCRUD();

            var mrB = new PersonModel
            {
                FirstName = "A",
                LastName = "A",
                Address = new AddressModel
                {
                    StreetAddress = "Sensación de vivir en Hospi",
                    City = "Hospi",
                    CP = "12345"
                }
            };
            personDB.Insert(mrB);


            //var mdb = new MongoCRUD.MongoCRUD("AddressBook");

            //var x = new PersonModel
            //{
            //    FirstName = "B",
            //    LastName = "B",
            //    Address = new AddressModel
            //    {
            //        StreetAddress = "Sensación de vivir en Hospi",
            //        City = "Hospi",
            //        CP = "12345"
            //    }
            //};
            //mdb.Insert("Users", x);

            //var persons = mdb.Read<PersonModel>("Users");
            //foreach (var person in persons)
            //{
            //    Console.WriteLine($"{person.Id}: {person.FirstName} {person.LastName}");
            //    if (person.Address != null)
            //    {
            //        Console.WriteLine($"{person.FirstName} address: {person.Address.StreetAddress} {person.Address.City} {person.Address.CP}");
            //    }
            //}

            //var mrXs = mdb.Read<PersonModel>("Users", x => x.Address.City == "Hospi");
            //foreach (var mrX in mrXs)
            //{
            //    Console.WriteLine($"{mrX.Id}: {mrX.FirstName} {mrX.LastName}");
            //    if (mrX.Address != null)
            //    {
            //        Console.WriteLine($"{mrX.FirstName} address: {mrX.Address.StreetAddress} {mrX.Address.City} {mrX.Address.CP}");
            //    }
            //}

            //var mrB = mdb.Read<PersonModel>("Users", x => x.FirstName == "B").FirstOrDefault();
            //if (mrB != null)
            //{
            //    //robert.Address = new AddressModel
            //    //{
            //    //    City = "Hospi",
            //    //    CP = "00000",
            //    //    StreetAddress = "Hospiiiiiii"
            //    //};

            //    //mdb.UpdateOrInsert("Users", robert);

            //    mdb.Delete("Users", mrB);
            //}


            Console.ReadLine();
        }
    }
}
