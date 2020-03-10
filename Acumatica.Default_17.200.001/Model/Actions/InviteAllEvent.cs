using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public partial class InviteAllEvent : EntityAction<Event>
	{
		public InviteAllEvent(Event entity) : base(entity)
		{ }
		public InviteAllEvent() : base()
		{ }
	}
}
