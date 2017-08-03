using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMongoDb.Data
{
    public class MongoDbContext
    {
        private static string DatabaseName = "";
        private static string ConnectionString = "";
        private static MongoClient Client;

        public MongoDbContext()
        {
            if (Client == null)
                Client = new MongoClient(ConnectionString);
        }

        public void GetDatabaseContext()
        {
        }
    }
}
