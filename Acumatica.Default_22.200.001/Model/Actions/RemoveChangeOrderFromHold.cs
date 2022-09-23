using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class RemoveChangeOrderFromHold : EntityAction<ChangeOrder>
	{
		public RemoveChangeOrderFromHold(ChangeOrder entity) : base(entity)
		{ }
		public RemoveChangeOrderFromHold() : base()
		{ }
	}
}
