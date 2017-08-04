using MongoDB.Driver;
using System;

namespace GenericMongoDb.Data
{
    /// <summary>
    /// Wrapper class for the MongoClient
    /// </summary>
    public class MongoDbClient
    {
        /// <summary>
        /// Name of the Database we want data from
        /// </summary>
        private static string DatabaseName = "TestDatabase";
        
        /// <summary>
        /// The connection string (IP-Adress + Port)
        /// </summary>
        private static string ConnectionString = "mongodb://localhost:27017";
        
        /// <summary>
        /// Threadsafe (According to the documentation)
        /// </summary>
        private static MongoClient Client;
        
        public MongoDbClient()
        {
            if (Client == null)
                Client = CreateClient();
        }

        /// <summary>
        /// Wrapper for creating client, so in the future when we want to make a more complex client, we just edit here.
        /// </summary>
        /// <returns></returns>
        private MongoClient CreateClient()
        {
            return new MongoClient(ConnectionString);
        }

        /// <summary>
        /// Returns the Database with the given name in the configuration.
        /// </summary>
        /// <returns>IMongoDatabase instance</returns>
        public IMongoDatabase GetContext()
        {
            if (Client == null) throw new NullReferenceException("Client not instantiated?");

            return Client.GetDatabase(DatabaseName);
        }

        public void DropContext()
        {
            if (Client == null) throw new NullReferenceException("Client not instantiated?");

            Client.DropDatabase(DatabaseName);
        }
    }
}
