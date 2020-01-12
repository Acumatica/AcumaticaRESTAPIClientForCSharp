
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class ProcessEmailProcessing : EntityAction<EmailProcessing>
    {
 public ProcessEmailProcessing(EmailProcessing entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public EmailProcessing Entity
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
