using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class MarkBusinessAccountAsValidated : EntityAction<BusinessAccount>
	{
		public MarkBusinessAccountAsValidated(BusinessAccount entity) : base(entity)
		{ }
		public MarkBusinessAccountAsValidated() : base()
		{ }
	}
}
