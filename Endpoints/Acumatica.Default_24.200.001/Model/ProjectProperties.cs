using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class ProjectProperties : Entity
	{

		[DataMember(Name="CertifiedJob", EmitDefaultValue=false)]
		public BooleanValue? CertifiedJob { get; set; }

		[DataMember(Name="ChangeOrderWorkflow", EmitDefaultValue=false)]
		public BooleanValue? ChangeOrderWorkflow { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		[DataMember(Name="LastRevenueChangeNbr", EmitDefaultValue=false)]
		public StringValue? LastRevenueChangeNbr { get; set; }

		[DataMember(Name="ProjectManager", EmitDefaultValue=false)]
		public StringValue? ProjectManager { get; set; }

		[DataMember(Name="RestrictEmployees", EmitDefaultValue=false)]
		public BooleanValue? RestrictEmployees { get; set; }

		[DataMember(Name="RestrictEquipment", EmitDefaultValue=false)]
		public BooleanValue? RestrictEquipment { get; set; }

		[DataMember(Name="RevenueBudgetLevel", EmitDefaultValue=false)]
		public StringValue? RevenueBudgetLevel { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="TrackProductionData", EmitDefaultValue=false)]
		public BooleanValue? TrackProductionData { get; set; }

		[DataMember(Name="CostBudgetLevel", EmitDefaultValue=false)]
		public StringValue? CostBudgetLevel { get; set; }

		[DataMember(Name="TimeActivityApprover", EmitDefaultValue=false)]
		public StringValue? TimeActivityApprover { get; set; }

		[DataMember(Name="ProjectCurrency", EmitDefaultValue=false)]
		public StringValue? ProjectCurrency { get; set; }

		[DataMember(Name="RateType", EmitDefaultValue=false)]
		public StringValue? RateType { get; set; }

		[DataMember(Name="InventoryTrackingMode", EmitDefaultValue=false)]
		public StringValue? InventoryTrackingMode { get; set; }

		[DataMember(Name="CostTaxZone", EmitDefaultValue=false)]
		public StringValue? CostTaxZone { get; set; }

		[DataMember(Name="RevenueTaxZone", EmitDefaultValue=false)]
		public StringValue? RevenueTaxZone { get; set; }

	}
}