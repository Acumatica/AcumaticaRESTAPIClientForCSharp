using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class SubcontractDetail : Entity
	{

		public StringValue? Account { get; set; }

		public StringValue? AlternateID { get; set; }

		public DecimalValue? Amount { get; set; }

		public StringValue? BranchID { get; set; }

		public BooleanValue? Canceled { get; set; }

		public BooleanValue? Closed { get; set; }

		public BooleanValue? Completed { get; set; }

		public StringValue? CostCode { get; set; }

		public StringValue? Description { get; set; }

		public DecimalValue? DiscountAmount { get; set; }

		public StringValue? DiscountCode { get; set; }

		public DecimalValue? DiscountPct { get; set; }

		public StringValue? DiscountSequence { get; set; }

		public DecimalValue? ExtendedCost { get; set; }

		public StringValue? InventoryID { get; set; }

		public StringValue? LineDescription { get; set; }

		public IntValue? LineNbr { get; set; }

		public BooleanValue? ManualCost { get; set; }

		public BooleanValue? ManualDiscount { get; set; }

		public StringValue? OrderNbr { get; set; }

		public DecimalValue? OrderQty { get; set; }

		public StringValue? OrderType { get; set; }

		public DecimalValue? PrepaidAmount { get; set; }

		public DecimalValue? PrepaidQty { get; set; }

		public StringValue? Project { get; set; }

		public StringValue? Task { get; set; }

		public DateTimeValue? Requested { get; set; }

		public DecimalValue? RetainageAmount { get; set; }

		public DecimalValue? RetainagePct { get; set; }

		public DateTimeValue? StartDate { get; set; }

		public StringValue? Subaccount { get; set; }

		public StringValue? TaxCategory { get; set; }

		public DecimalValue? UnitCost { get; set; }

		public StringValue? UOM { get; set; }

	}
}