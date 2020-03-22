using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ReleaseCase : EntityAction<Case>
	{
		public ReleaseCase(Case entity) : base(entity)
		{ }
		public ReleaseCase() : base()
		{ }
	}
}
