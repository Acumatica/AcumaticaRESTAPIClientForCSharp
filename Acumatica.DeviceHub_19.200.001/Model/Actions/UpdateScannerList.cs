
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DeviceHub_19_200_001.Model
{
    [DataContract]
    public partial class UpdateScannerList : EntityAction<Scanner>
    {
        public UpdateScannerList(Scanner entity) : base(entity)
        { }

        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public Scanner Entity
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
