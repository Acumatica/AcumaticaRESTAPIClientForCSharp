using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
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
