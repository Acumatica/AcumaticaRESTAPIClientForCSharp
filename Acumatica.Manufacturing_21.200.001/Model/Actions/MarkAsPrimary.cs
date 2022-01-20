using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class MarkAsPrimary : EntityAction<Estimate>
	{
		public MarkAsPrimary(Estimate entity) : base(entity)
		{ }
		public MarkAsPrimary() : base()
		{ }
	}
}
