using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class EmployeePaycheckEarningDetail : Entity
	{

		public StringValue? Account { get; set; }

		public DecimalValue? Amount { get; set; }

		public StringValue? Branch { get; set; }

		public BooleanValue? CertifiedJob { get; set; }

		public StringValue? Code { get; set; }

		public StringValue? CostCode { get; set; }

		public DateTimeValue? Date { get; set; }

		public StringValue? Description { get; set; }

		public DecimalValue? Hours { get; set; }

		public StringValue? LaborItem { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? Location { get; set; }

		public BooleanValue? ManualRate { get; set; }

		public StringValue? Project { get; set; }

		public DecimalValue? Rate { get; set; }

		public StringValue? ShiftCode { get; set; }

		public StringValue? Subaccount { get; set; }

		public StringValue? Task { get; set; }

		public StringValue? UnionLocal { get; set; }

		public DecimalValue? Units { get; set; }

		public StringValue? UnitType { get; set; }

		public StringValue? WCCCode { get; set; }

	}
}