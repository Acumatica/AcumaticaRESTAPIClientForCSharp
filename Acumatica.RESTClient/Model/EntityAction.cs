using System;
using System.IO;

namespace Acumatica.RESTClient.Model
{
    public abstract class EntityAction<EntityType>
        where EntityType : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Action" /> class.
        /// </summary>
        /// <param name="entity">entity (required).</param>
        public EntityAction(EntityType entity)
        {
            // to ensure "entity" is required (not null)
            if (entity == null)
            {
                throw new InvalidDataException("entity is a required property for Action and cannot be null");
            }
            else
            {
                this._Entity = entity;
            }
        }

        protected EntityType _Entity { get; set; }
    }

}
