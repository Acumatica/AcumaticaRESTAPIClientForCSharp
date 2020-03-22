using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class ReleasePayment : EntityAction<Payment>
	{
		public ReleasePayment(Payment entity) : base(entity)
		{ }
		public ReleasePayment() : base()
		{ }
	}
}
