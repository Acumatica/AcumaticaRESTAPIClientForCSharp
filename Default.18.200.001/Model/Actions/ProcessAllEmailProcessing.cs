
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ProcessAllEmailProcessing : EntityAction<EmailProcessing>
    {
 public ProcessAllEmailProcessing(EmailProcessing entity) : base(entity)
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
