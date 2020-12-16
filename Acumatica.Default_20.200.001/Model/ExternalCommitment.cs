using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ExternalCommitment : Entity_v4
	{

		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue AccountGroup { get; set; }

		[DataMember(Name="CommittedCOAmount", EmitDefaultValue=false)]
		public DecimalValue CommittedCOAmount { get; set; }

		[DataMember(Name="CommittedCOQty", EmitDefaultValue=false)]
		public DecimalValue CommittedCOQty { get; set; }

		[DataMember(Name="CommittedInvoicedAmount", EmitDefaultValue=false)]
		public DecimalValue CommittedInvoicedAmount { get; set; }

		[DataMember(Name="CommittedInvoicedQty", EmitDefaultValue=false)]
		public DecimalValue CommittedInvoicedQty { get; set; }

		[DataMember(Name="CommittedOpenAmount", EmitDefaultValue=false)]
		public DecimalValue CommittedOpenAmount { get; set; }

		[DataMember(Name="CommittedOpenQty", EmitDefaultValue=false)]
		public DecimalValue CommittedOpenQty { get; set; }

		[DataMember(Name="CommittedReceivedQty", EmitDefaultValue=false)]
		public DecimalValue CommittedReceivedQty { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue ExternalRefNbr { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="OriginalCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue OriginalCommittedAmount { get; set; }

		[DataMember(Name="OriginalCommittedQty", EmitDefaultValue=false)]
		public DecimalValue OriginalCommittedQty { get; set; }

		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue ProjectID { get; set; }

		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue ProjectTaskID { get; set; }

		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public StringValue RelatedDocument { get; set; }

		[DataMember(Name="RevisedCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue RevisedCommittedAmount { get; set; }

		[DataMember(Name="RevisedCommittedQty", EmitDefaultValue=false)]
		public DecimalValue RevisedCommittedQty { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

	}
}