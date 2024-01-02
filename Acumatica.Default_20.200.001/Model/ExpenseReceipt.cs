using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ExpenseReceipt : Entity, ITopLevelEntity
	{

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		[DataMember(Name="ClaimAmount", EmitDefaultValue=false)]
		public DecimalValue? ClaimAmount { get; set; }

		[DataMember(Name="ClaimedBy", EmitDefaultValue=false)]
		public StringValue? ClaimedBy { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		[DataMember(Name="ExpenseItemID", EmitDefaultValue=false)]
		public StringValue? ExpenseItemID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="ReceiptDetails", EmitDefaultValue=false)]
		public ExpenseReceiptDetails? ReceiptDetails { get; set; }

		[DataMember(Name="ReceiptID", EmitDefaultValue=false)]
		public StringValue? ReceiptID { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<ExpenseReceiptTaxDetails>? TaxDetails { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/20.200.001";
		}
	}
}