using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class UnlockProjectCommitments : EntityAction<Project>
	{
		public UnlockProjectCommitments(Project entity) : base(entity)
		{ }
		public UnlockProjectCommitments() : base()
		{ }
	}
}
