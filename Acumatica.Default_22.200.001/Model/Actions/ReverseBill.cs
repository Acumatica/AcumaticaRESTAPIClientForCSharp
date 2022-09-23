using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ReverseBill : EntityAction<Bill>
	{
		public ReverseBill(Bill entity) : base(entity)
		{ }
		public ReverseBill() : base()
		{ }
	}
}
