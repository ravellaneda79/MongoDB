using MongoCRUD;
using PoC_MongoDb;

namespace MongoDbAccess
{
    public class PersonCRUD : MongoCRUD<PersonModel>
    {
        public PersonCRUD() : base(SettingsProvider.GetPersonSettings())
        {
        }
    }
}
