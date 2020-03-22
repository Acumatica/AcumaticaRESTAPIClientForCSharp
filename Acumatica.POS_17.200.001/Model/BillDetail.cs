using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class BillDetail : Entity
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
		public DecimalValue ExtendedCost { get; set; }

		[DataMember(Name="NonBillable", EmitDefaultValue=false)]
		public BooleanValue NonBillable { get; set; }

		[DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
		public StringValue POOrderNbr { get; set; }

		[DataMember(Name="POOrderType", EmitDefaultValue=false)]
		public StringValue POOrderType { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue TransactionDescription { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue UnitCost { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

	}
}