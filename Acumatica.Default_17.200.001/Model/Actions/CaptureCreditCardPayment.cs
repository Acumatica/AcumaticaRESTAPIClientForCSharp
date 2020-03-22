using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class CaptureCreditCardPayment : EntityAction<Payment>
	{
		public CaptureCreditCardPayment(Payment entity) : base(entity)
		{ }
		public CaptureCreditCardPayment() : base()
		{ }
	}
}
