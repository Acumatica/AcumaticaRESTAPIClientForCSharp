
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DeviceHub_19_200_001.Model
{
    [DataContract]
    public partial class UpdatePrinterList : EntityAction<Printer>
    {
        public UpdatePrinterList(Printer entity) : base(entity)
        { }

        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public Printer Entity
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
