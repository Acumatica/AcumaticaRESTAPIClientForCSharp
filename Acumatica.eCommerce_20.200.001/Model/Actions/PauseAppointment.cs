using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class PauseAppointment : EntityAction<Appointment>
	{
		public PauseAppointment(Appointment entity) : base(entity)
		{ }
		public PauseAppointment() : base()
		{ }
	}
}
