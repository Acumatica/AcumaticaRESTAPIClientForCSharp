using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class CheckForContactDuplicates : EntityAction<Contact>
	{
		public CheckForContactDuplicates(Contact entity) : base(entity)
		{ }
		public CheckForContactDuplicates() : base()
		{ }
	}
}
