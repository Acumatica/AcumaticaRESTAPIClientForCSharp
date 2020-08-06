using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ValidateBusinessAccountAddresses : EntityAction<BusinessAccount>
	{
		public ValidateBusinessAccountAddresses(BusinessAccount entity) : base(entity)
		{ }
		public ValidateBusinessAccountAddresses() : base()
		{ }
	}
}
