using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
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
