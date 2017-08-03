using MongoDB.Driver;
using System;

namespace GenericMongoDb.Data
{
    /// <summary>
    /// Wrapper class for the MongoClient
    /// </summary>
    public class MongoDbContext
    {
        /// <summary>
        /// Name of the Database we want data from
        /// </summary>
        private static string DatabaseName = "MyDatabase";
        
        /// <summary>
        /// The connection string (IP-Adress + Port)
        /// </summary>
        private static string ConnectionString = "mongodb://localhost:27017";
        
        /// <summary>
        /// Us as a client
        /// </summary>
        private static MongoClient Client;
        
        public MongoDbContext()
        {
            if (Client == null)
                Client = new MongoClient(ConnectionString);
        }

        /// <summary>
        /// Returns the Database with the given name in the configuration.
        /// </summary>
        /// <returns>IMongoDatabase instance</returns>
        public IMongoDatabase GetDatabase()
        {
            if (Client != null)
                return Client.GetDatabase(DatabaseName);

            throw new NullReferenceException("Client not instantiated?");
        }
    }
}
