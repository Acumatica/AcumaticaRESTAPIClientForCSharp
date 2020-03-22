using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class SelectRelatedEntityEvent : EntityActionWithParameters<Event, SelectRelatedEntityEventParameters>
	{
		public SelectRelatedEntityEvent() : base()
		{ }
		public SelectRelatedEntityEvent(Event entity, SelectRelatedEntityEventParameters parameters) : base(entity, parameters)
		{ }
	}
}