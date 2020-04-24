using System;
using MongoCRUD;
using PoC_MongoDb;
using Xunit;

namespace MongoCRUDTests
{
    public class MongoDbAccessTests
    {
        private const string DataBaseTests = "AddressBookTests";
        private const string UsersCollection = "Users";

        [Fact]
        public void GivenAPersonWithoutAddress_WhenInsert_ThenOnlyInsertPerson()
        {
            var mdb = new MongoCRUD.MongoCRUD(DataBaseTests);
            mdb.Insert(UsersCollection, new PersonModel { FirstName = "Robert", LastName = "Avellaneda" });
        }

        [Fact]
        public void GivenAPersonWithAddress_WhenInsert_ThenInsertAllPersonInformation()
        {
            var mdb = new MongoCRUD.MongoCRUD(DataBaseTests);
            mdb.Insert<PersonModel>(UsersCollection, 
                new PersonModel
                {
                    FirstName = "A", 
                    LastName = "A",
                    Address = new AddressModel
                    {
                        StreetAddress = "Somewhere on Hospi",
                        City = "Hospi",
                        CP = "12345"
                    }
                });
        }
    }
}
