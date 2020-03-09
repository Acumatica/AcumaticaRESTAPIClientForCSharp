
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DeviceHub_17_200_001.Model
{
    [DataContract]
    public partial class UpdatePrinterList : EntityAction<Printer>
    {
        public UpdatePrinterList(Printer entity) : base(entity)
        { }
    }
}
