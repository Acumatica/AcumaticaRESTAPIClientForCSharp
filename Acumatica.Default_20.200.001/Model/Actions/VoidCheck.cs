using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class VoidCheck : EntityAction<Check>
	{
		public VoidCheck(Check entity) : base(entity)
		{ }
		public VoidCheck() : base()
		{ }
	}
}
