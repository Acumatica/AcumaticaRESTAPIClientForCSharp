using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class RunProjectBilling : EntityAction<Project>
	{
		public RunProjectBilling(Project entity) : base(entity)
		{ }
		public RunProjectBilling() : base()
		{ }
	}
}
