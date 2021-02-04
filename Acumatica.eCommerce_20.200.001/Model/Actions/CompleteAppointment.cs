using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class CompleteAppointment : EntityAction<Appointment>
	{
		public CompleteAppointment(Appointment entity) : base(entity)
		{ }
		public CompleteAppointment() : base()
		{ }
	}
}
