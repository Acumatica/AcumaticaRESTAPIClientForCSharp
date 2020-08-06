using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CheckForBusinessAccountDuplicates : EntityAction<BusinessAccount>
	{
		public CheckForBusinessAccountDuplicates(BusinessAccount entity) : base(entity)
		{ }
		public CheckForBusinessAccountDuplicates() : base()
		{ }
	}
}
