using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class ReleaseMaterialEntry : EntityAction<MaterialEntry>
	{
		public ReleaseMaterialEntry(MaterialEntry entity) : base(entity)
		{ }
		public ReleaseMaterialEntry() : base()
		{ }
	}
}
