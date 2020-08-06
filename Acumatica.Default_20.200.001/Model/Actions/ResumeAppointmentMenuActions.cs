using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ResumeAppointmentMenuActions : EntityAction<Appointment>
	{
		public ResumeAppointmentMenuActions(Appointment entity) : base(entity)
		{ }
		public ResumeAppointmentMenuActions() : base()
		{ }
	}
}
