using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
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
