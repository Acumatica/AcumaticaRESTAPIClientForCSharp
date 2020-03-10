using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class ReleaseCheck : EntityAction<Check>
	{
		public ReleaseCheck(Check entity) : base(entity)
		{ }
		public ReleaseCheck() : base()
		{ }
	}
}
