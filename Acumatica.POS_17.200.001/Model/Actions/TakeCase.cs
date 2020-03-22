using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class TakeCase : EntityAction<Case>
	{
		public TakeCase(Case entity) : base(entity)
		{ }
		public TakeCase() : base()
		{ }
	}
}
