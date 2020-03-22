using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class ConvertContactToBusinessAccount : EntityActionWithParameters<Contact, ConvertContactToBusinessAccountParameters>
	{
		public ConvertContactToBusinessAccount() : base()
		{ }
		public ConvertContactToBusinessAccount(Contact entity, ConvertContactToBusinessAccountParameters parameters) : base(entity, parameters)
		{ }
	}
}