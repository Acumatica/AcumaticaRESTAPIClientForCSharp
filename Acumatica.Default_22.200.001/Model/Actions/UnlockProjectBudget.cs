using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class UnlockProjectBudget : EntityAction<Project>
	{
		public UnlockProjectBudget(Project entity) : base(entity)
		{ }
		public UnlockProjectBudget() : base()
		{ }
	}
}
