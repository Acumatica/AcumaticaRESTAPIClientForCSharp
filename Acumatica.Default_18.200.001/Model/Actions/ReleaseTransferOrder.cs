using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class ReleaseTransferOrder : EntityAction<TransferOrder>
	{
		public ReleaseTransferOrder(TransferOrder entity) : base(entity)
		{ }
		public ReleaseTransferOrder() : base()
		{ }
	}
}
