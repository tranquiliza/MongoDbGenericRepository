using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMongoDb.Data;
using GenericMongoDb.Core;
using GenericMongoDb.Core.Infrastructure;
using GenericMongoDb.Core.Domain.TestEntities;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoDbClient myClient = new MongoDbClient();

            IUnitOfWork uow = new UnitOfWork(myClient);


            var thingToUpdate = uow.GamerRepository.GetByID(0);
            Console.WriteLine("Retrieved: " + thingToUpdate.Name);


            thingToUpdate.SetName("Daniel");

            Console.WriteLine("Core Executed!");

            uow.GamerRepository.Update(thingToUpdate);
            Console.WriteLine("Query Executed!");

            var isThisUpdated = uow.GamerRepository.GetByID(0);
            Console.WriteLine("Now named: " + isThisUpdated.Name);


            Console.Read();
        }
    }
}
