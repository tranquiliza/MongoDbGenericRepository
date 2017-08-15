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

            //uow.GamerRepository.DeleteAll();

            //uow.GamerRepository.Insert(new Gamer("Test"));

            //for (int i = 0; i < 1000; i++)
            //{
            //    uow.GamerRepository.Insert(new Gamer($"Number: {i}"));
            //}

            var myItem = uow.GamerRepository.GetById(new Guid("15c81567-cc4c-44bf-9436-29c88ab1507a"));
            myItem.SetName("NewName!");
            uow.GamerRepository.Update(myItem);

            //var thingToUpdate = uow.GamerRepository.GetByID(0);
            //Console.WriteLine("Retrieved: " + thingToUpdate.Name);


            //thingToUpdate.SetName("Daniel");

            //Console.WriteLine("Core Executed!");

            //uow.GamerRepository.Update(thingToUpdate);
            //Console.WriteLine("Query Executed!");

            //var isThisUpdated = uow.GamerRepository.GetByID(0);
            //Console.WriteLine("Now named: " + isThisUpdated.Name);

            var listOfAllEntries = uow.GamerRepository.GetAll();
            foreach (var item in listOfAllEntries)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }

            Console.Read();
        }
    }
}
