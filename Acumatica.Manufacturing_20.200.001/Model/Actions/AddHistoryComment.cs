using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class AddHistoryComment : EntityAction<Estimate>
	{
		public AddHistoryComment(Estimate entity) : base(entity)
		{ }
		public AddHistoryComment() : base()
		{ }
	}
}
