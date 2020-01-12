
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class ReleaseJournalTransaction : EntityAction<JournalTransaction>
    {
 public ReleaseJournalTransaction(JournalTransaction entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public JournalTransaction Entity
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
