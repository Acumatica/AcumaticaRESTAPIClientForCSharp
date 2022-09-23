using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ApproveChangeOrder : EntityAction<ChangeOrder>
	{
		public ApproveChangeOrder(ChangeOrder entity) : base(entity)
		{ }
		public ApproveChangeOrder() : base()
		{ }
	}
}
