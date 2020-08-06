using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
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
