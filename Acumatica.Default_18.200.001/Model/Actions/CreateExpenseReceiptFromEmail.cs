using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class CreateExpenseReceiptFromEmail : EntityAction<Email>
	{
		public CreateExpenseReceiptFromEmail(Email entity) : base(entity)
		{ }
		public CreateExpenseReceiptFromEmail() : base()
		{ }
	}
}
