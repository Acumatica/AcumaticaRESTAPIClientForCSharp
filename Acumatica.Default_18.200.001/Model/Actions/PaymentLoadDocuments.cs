using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class PaymentLoadDocuments : EntityActionWithParameters<Payment, PaymentLoadDocumentsParameters>
	{
		public PaymentLoadDocuments() : base()
		{ }
		public PaymentLoadDocuments(Payment entity, PaymentLoadDocumentsParameters parameters) : base(entity, parameters)
		{ }
	}
}