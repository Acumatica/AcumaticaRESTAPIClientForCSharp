using System.IO;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    public abstract class EntityActionWithParameters<EntityType, ParameterType> : EntityAction<EntityType>
        where EntityType : Entity, ITopLevelEntity
        where ParameterType : new()
    {
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

        public ParameterType Parameters { get; set; }
    }

}
