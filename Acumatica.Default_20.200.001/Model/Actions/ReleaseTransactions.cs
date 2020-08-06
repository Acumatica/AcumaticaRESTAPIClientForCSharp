using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ReleaseTransactions : EntityAction<ProjectTransaction>
	{
		public ReleaseTransactions(ProjectTransaction entity) : base(entity)
		{ }
		public ReleaseTransactions() : base()
		{ }
	}
}
