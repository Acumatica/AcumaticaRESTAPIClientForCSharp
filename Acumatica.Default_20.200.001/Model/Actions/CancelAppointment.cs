using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CancelAppointment : EntityAction<Appointment>
	{
		public CancelAppointment(Appointment entity) : base(entity)
		{ }
		public CancelAppointment() : base()
		{ }
	}
}
