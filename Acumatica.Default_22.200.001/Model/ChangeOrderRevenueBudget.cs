using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ChangeOrderRevenueBudget : Entity
	{

		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue? AccountGroup { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="OtherDraftCOAmount", EmitDefaultValue=false)]
		public DecimalValue? OtherDraftCOAmount { get; set; }

		[DataMember(Name="PreviouslyApprovedCOAmount", EmitDefaultValue=false)]
		public DecimalValue? PreviouslyApprovedCOAmount { get; set; }

		[DataMember(Name="PreviouslyApprovedCOQty", EmitDefaultValue=false)]
		public DecimalValue? PreviouslyApprovedCOQty { get; set; }

		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		[DataMember(Name="RevisedBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue? RevisedBudgetedAmount { get; set; }

		[DataMember(Name="RevisedBudgetedQty", EmitDefaultValue=false)]
		public DecimalValue? RevisedBudgetedQty { get; set; }

		[DataMember(Name="TotalPotentiallyRevisedAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalPotentiallyRevisedAmount { get; set; }

		[DataMember(Name="UnitRate", EmitDefaultValue=false)]
		public DecimalValue? UnitRate { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}