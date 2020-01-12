
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class CreateOpportunityInvoice : EntityAction<Opportunity>
    {
 public CreateOpportunityInvoice(Opportunity entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Opportunity Entity
        {
            get
            {
                return _Entity;
            }
            set
            {
                _Entity = value;
            }
        }
    }
}
