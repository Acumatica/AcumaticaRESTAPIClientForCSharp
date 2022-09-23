using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class HoldChangeOrder : EntityAction<ChangeOrder>
	{
		public HoldChangeOrder(ChangeOrder entity) : base(entity)
		{ }
		public HoldChangeOrder() : base()
		{ }
	}
}
