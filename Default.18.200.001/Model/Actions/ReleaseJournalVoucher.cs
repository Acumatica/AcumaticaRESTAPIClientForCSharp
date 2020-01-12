
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class ReleaseJournalVoucher : EntityAction<JournalVoucher>
    {
 public ReleaseJournalVoucher(JournalVoucher entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public JournalVoucher Entity
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
