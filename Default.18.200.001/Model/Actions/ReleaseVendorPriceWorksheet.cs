
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReleaseVendorPriceWorksheet : EntityAction<VendorPriceWorksheet>
    {
 public ReleaseVendorPriceWorksheet(VendorPriceWorksheet entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public VendorPriceWorksheet Entity
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
