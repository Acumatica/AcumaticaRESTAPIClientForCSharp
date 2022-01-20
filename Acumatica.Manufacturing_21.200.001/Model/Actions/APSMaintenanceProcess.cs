using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class APSMaintenanceProcess : EntityAction<APSMaintenance>
	{
		public APSMaintenanceProcess(APSMaintenance entity) : base(entity)
		{ }
		public APSMaintenanceProcess() : base()
		{ }
	}
}
