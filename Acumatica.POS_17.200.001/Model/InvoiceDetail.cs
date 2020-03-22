using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class InvoiceDetail : Entity
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue DiscountAmount { get; set; }

		[DataMember(Name="ExtendedPrice", EmitDefaultValue=false)]
		public DecimalValue ExtendedPrice { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue TransactionDescription { get; set; }

		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue UnitPrice { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

	}
}