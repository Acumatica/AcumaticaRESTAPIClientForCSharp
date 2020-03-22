using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DeviceHub_17_200_001.Model
{
	[DataContract]
	public class UpdatePrinterList : EntityAction<Printer>
	{
		public UpdatePrinterList(Printer entity) : base(entity)
		{ }
		public UpdatePrinterList() : base()
		{ }
	}
}
