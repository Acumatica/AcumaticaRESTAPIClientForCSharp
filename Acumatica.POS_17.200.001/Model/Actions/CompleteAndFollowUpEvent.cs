using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class CompleteAndFollowUpEvent : EntityAction<Event>
	{
		public CompleteAndFollowUpEvent(Event entity) : base(entity)
		{ }
		public CompleteAndFollowUpEvent() : base()
		{ }
	}
}
