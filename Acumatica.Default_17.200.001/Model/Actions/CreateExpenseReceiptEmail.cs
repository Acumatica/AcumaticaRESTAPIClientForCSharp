using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class CreateExpenseReceiptEmail : EntityAction<Email>
	{
		public CreateExpenseReceiptEmail(Email entity) : base(entity)
		{ }
		public CreateExpenseReceiptEmail() : base()
		{ }
	}
}
