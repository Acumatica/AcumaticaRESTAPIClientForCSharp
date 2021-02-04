using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class ReleaseLaborEntry : EntityAction<LaborEntry>
	{
		public ReleaseLaborEntry(LaborEntry entity) : base(entity)
		{ }
		public ReleaseLaborEntry() : base()
		{ }
	}
}
