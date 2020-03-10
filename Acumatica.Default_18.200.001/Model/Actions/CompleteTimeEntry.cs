using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class CompleteTimeEntry : EntityAction<TimeEntry>
	{
		public CompleteTimeEntry(TimeEntry entity) : base(entity)
		{ }
		public CompleteTimeEntry() : base()
		{ }
	}
}
