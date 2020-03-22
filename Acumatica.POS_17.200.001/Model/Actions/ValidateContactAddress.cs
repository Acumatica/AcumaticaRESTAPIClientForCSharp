using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class ValidateContactAddress : EntityAction<Contact>
	{
		public ValidateContactAddress(Contact entity) : base(entity)
		{ }
		public ValidateContactAddress() : base()
		{ }
	}
}
