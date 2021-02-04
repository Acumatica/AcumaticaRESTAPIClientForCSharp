using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class InvoiceAppointment : EntityAction<Appointment>
	{
		public InvoiceAppointment(Appointment entity) : base(entity)
		{ }
		public InvoiceAppointment() : base()
		{ }
	}
}
