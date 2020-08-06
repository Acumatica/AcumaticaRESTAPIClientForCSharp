using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class UncloseAppointmentMenuActions : EntityAction<Appointment>
	{
		public UncloseAppointmentMenuActions(Appointment entity) : base(entity)
		{ }
		public UncloseAppointmentMenuActions() : base()
		{ }
	}
}
