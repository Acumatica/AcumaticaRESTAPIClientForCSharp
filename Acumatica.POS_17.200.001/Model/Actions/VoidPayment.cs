using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class VoidPayment : EntityAction<Payment>
	{
		public VoidPayment(Payment entity) : base(entity)
		{ }
		public VoidPayment() : base()
		{ }
	}
}
