using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class UnlockProjectCommitments : EntityAction<Project>
	{
		public UnlockProjectCommitments(Project entity) : base(entity)
		{ }
		public UnlockProjectCommitments() : base()
		{ }
	}
}
