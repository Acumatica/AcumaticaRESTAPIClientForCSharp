using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class ExportCardEvent : EntityAction<Event>
	{
		public ExportCardEvent(Event entity) : base(entity)
		{ }
		public ExportCardEvent() : base()
		{ }
	}
}
