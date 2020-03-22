using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class LinkEntityToEvent : EntityActionWithParameters<Event, LinkEntityToEventParameters>
	{
		public LinkEntityToEvent() : base()
		{ }
		public LinkEntityToEvent(Event entity, LinkEntityToEventParameters parameters) : base(entity, parameters)
		{ }
	}
}