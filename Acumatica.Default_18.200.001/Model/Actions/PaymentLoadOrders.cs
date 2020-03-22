using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class PaymentLoadOrders : EntityActionWithParameters<Payment, PaymentLoadOrdersParameters>
	{
		public PaymentLoadOrders() : base()
		{ }
		public PaymentLoadOrders(Payment entity, PaymentLoadOrdersParameters parameters) : base(entity, parameters)
		{ }
	}
}