using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ReleaseInventoryIssue : EntityAction<InventoryIssue>
	{
		public ReleaseInventoryIssue(InventoryIssue entity) : base(entity)
		{ }
		public ReleaseInventoryIssue() : base()
		{ }
	}
}
