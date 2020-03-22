using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DeviceHub_19_200_001.Model
{
	[DataContract]
	public class UpdateScannerList : EntityAction<Scanner>
	{
		public UpdateScannerList(Scanner entity) : base(entity)
		{ }
		public UpdateScannerList() : base()
		{ }
	}
}
