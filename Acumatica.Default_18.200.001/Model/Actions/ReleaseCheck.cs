using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ReleaseCheck : EntityAction<Check>
	{
		public ReleaseCheck(Check entity) : base(entity)
		{ }
		public ReleaseCheck() : base()
		{ }
	}
}
