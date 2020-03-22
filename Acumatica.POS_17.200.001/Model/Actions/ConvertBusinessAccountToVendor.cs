using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class ConvertBusinessAccountToVendor : EntityAction<BusinessAccount>
	{
		public ConvertBusinessAccountToVendor(BusinessAccount entity) : base(entity)
		{ }
		public ConvertBusinessAccountToVendor() : base()
		{ }
	}
}
