using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class SelectRelatedEntityEvent : EntityActionWithParameters<Event, SelectRelatedEntityEventParameters>
	{
		public SelectRelatedEntityEvent() : base()
		{ }
		public SelectRelatedEntityEvent(Event entity, SelectRelatedEntityEventParameters parameters) : base(entity, parameters)
		{ }

		public StringValue RelatedEntity
		{
			get { return Parameters.RelatedEntity; }
			set { Parameters.RelatedEntity = value; }
		}
		public StringValue Type
		{
			get { return Parameters.Type; }
			set { Parameters.Type = value; }
		}
	}
}