using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ReverseChangeOrder : EntityAction<ChangeOrder>
	{
		public ReverseChangeOrder(ChangeOrder entity) : base(entity)
		{ }
		public ReverseChangeOrder() : base()
		{ }
	}
}
