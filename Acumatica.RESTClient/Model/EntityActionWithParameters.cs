using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.Model
{
    [DataContract]
    public abstract class EntityActionWithParameters<EntityType, ParameterType> : EntityAction<EntityType>
        where EntityType : Entity
    {

        public EntityActionWithParameters() :base()
        {
        }

        public EntityActionWithParameters(EntityType entity, ParameterType parameters) : base(entity)
        {
            // to ensure "parameters" is required (not null)
            if (parameters == null)
            {
                throw new InvalidDataException("parameters is a required property for ActionWithParameters and cannot be null");
            }
            else
            {
                this.Parameters = parameters;
            }
        }

        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public ParameterType Parameters { get; set; }
    }

}
