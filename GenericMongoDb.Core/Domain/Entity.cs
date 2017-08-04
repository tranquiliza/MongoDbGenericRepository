using System;

namespace GenericMongoDb.Core.Domain
{
    public abstract class Entity
    {
        public virtual Guid Id { get; set; }

        protected Entity()
        {
            Id = new Guid();
        }
    }
}
