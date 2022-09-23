using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class OpenTimeEntry : EntityAction<TimeEntry>
	{
		public OpenTimeEntry(TimeEntry entity) : base(entity)
		{ }
		public OpenTimeEntry() : base()
		{ }
	}
}
