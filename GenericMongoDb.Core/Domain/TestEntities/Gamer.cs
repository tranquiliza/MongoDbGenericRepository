using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMongoDb.Core.Domain.TestEntities
{
    public class Gamer : Entity
    {
        public string Name { get; private set; }

        public Gamer(string name)
        {
            SetName(name);
        }

        public void SetName(string name)
        {
            if (name == string.Empty) throw new ArgumentException("Given string was empty");

            Name = name;
        }
    }
}
