using MongoCRUD;
using MongoDB.Bson.Serialization.Attributes;

namespace PoC_MongoDb
{
    public class PersonModel : MModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel Address { get; set; }
    }
}
