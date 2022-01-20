using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ConfigurationMaintenanceSetActive : EntityAction<ConfigurationMaintenance>
	{
		public ConfigurationMaintenanceSetActive(ConfigurationMaintenance entity) : base(entity)
		{ }
		public ConfigurationMaintenanceSetActive() : base()
		{ }
	}
}
