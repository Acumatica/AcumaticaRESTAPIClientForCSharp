using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ProjectProperties : Entity
	{

		public BooleanValue? CertifiedJob { get; set; }

		public BooleanValue? ChangeOrderWorkflow { get; set; }

		public DateTimeValue? EndDate { get; set; }

		public StringValue? LastRevenueChangeNbr { get; set; }

		public StringValue? ProjectManager { get; set; }

		public BooleanValue? RestrictEmployees { get; set; }

		public BooleanValue? RestrictEquipment { get; set; }

		public StringValue? RevenueBudgetLevel { get; set; }

		public DateTimeValue? StartDate { get; set; }

		public BooleanValue? TrackProductionData { get; set; }

		public StringValue? CostBudgetLevel { get; set; }

		public StringValue? TimeActivityApprover { get; set; }

		public StringValue? ProjectCurrency { get; set; }

		public StringValue? RateType { get; set; }

		public StringValue? InventoryTrackingMode { get; set; }

		public StringValue? CostTaxZone { get; set; }

		public StringValue? RevenueTaxZone { get; set; }

	}
}