using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class StartAppointment : EntityAction<Appointment>
	{
		public StartAppointment(Appointment entity) : base(entity)
		{ }
		public StartAppointment() : base()
		{ }
	}
}
