using MongoDbAccess;

namespace PoC_MongoDb
{
    public static class SettingsProvider
    {
        public static MongoSettings GetPersonSettings()
        {
            return new MongoSettings
            {
                DataBaseName = "AddressBook",
                CollectionName = "Users"
            };
        }
    }
}
