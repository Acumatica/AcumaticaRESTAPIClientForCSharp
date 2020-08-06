using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class AppRecalcExternalTax : EntityAction<Appointment>
	{
		public AppRecalcExternalTax(Appointment entity) : base(entity)
		{ }
		public AppRecalcExternalTax() : base()
		{ }
	}
}
