using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class EmployeePaidTimeOffDetail : Entity
	{

		public DecimalValue? AccrualLimit { get; set; }

		public StringValue? AccrualMethod { get; set; }

		public DecimalValue? AccrualPercent { get; set; }

		public BooleanValue? Active { get; set; }

		public DecimalValue? AmountAccrued { get; set; }

		public DecimalValue? AmountAvailable { get; set; }

		public DecimalValue? AmountUsed { get; set; }

		public DecimalValue? CarryoverAmount { get; set; }

		public StringValue? CarryoverType { get; set; }

		public BooleanValue? CreateFinancialTransaction { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? DisbursingType { get; set; }

		public DateTimeValue? EffectiveDate { get; set; }

		public DecimalValue? FrontLoadingAmount { get; set; }

		public DecimalValue? HoursAccrued { get; set; }

		public DecimalValue? HoursAvailable { get; set; }

		public DecimalValue? HoursPerYear { get; set; }

		public DecimalValue? HoursUsed { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? PTOBank { get; set; }

		public BooleanValue? UseClassDefaultValues { get; set; }

	}
}