using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ConvertLeadToBAccount : EntityActionWithParameters<Lead, ConvertLeadToBAccountParameters>
	{
		public ConvertLeadToBAccount() : base()
		{ }
		public ConvertLeadToBAccount(Lead entity, ConvertLeadToBAccountParameters parameters) : base(entity, parameters)
		{ }
	}
}