using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class LockProjectCommitments : EntityAction<Project>
	{
		public LockProjectCommitments(Project entity) : base(entity)
		{ }
		public LockProjectCommitments() : base()
		{ }
	}
}
