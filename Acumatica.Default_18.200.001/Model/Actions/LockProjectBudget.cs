using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class LockProjectBudget : EntityAction<Project>
	{
		public LockProjectBudget(Project entity) : base(entity)
		{ }
		public LockProjectBudget() : base()
		{ }
	}
}
