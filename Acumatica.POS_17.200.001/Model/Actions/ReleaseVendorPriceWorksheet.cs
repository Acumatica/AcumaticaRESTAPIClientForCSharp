using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class ReleaseVendorPriceWorksheet : EntityAction<VendorPriceWorksheet>
	{
		public ReleaseVendorPriceWorksheet(VendorPriceWorksheet entity) : base(entity)
		{ }
		public ReleaseVendorPriceWorksheet() : base()
		{ }
	}
}
