using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CloseAppointment : EntityAction<Appointment>
	{
		public CloseAppointment(Appointment entity) : base(entity)
		{ }
		public CloseAppointment() : base()
		{ }
	}
}
