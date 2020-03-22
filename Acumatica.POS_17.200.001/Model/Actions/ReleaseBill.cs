using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class ReleaseBill : EntityAction<Bill>
	{
		public ReleaseBill(Bill entity) : base(entity)
		{ }
		public ReleaseBill() : base()
		{ }
	}
}
