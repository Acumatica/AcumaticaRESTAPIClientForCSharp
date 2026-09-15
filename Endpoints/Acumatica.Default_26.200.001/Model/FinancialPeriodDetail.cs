using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class FinancialPeriodDetail : Entity
	{

		[DataMember(Name="AdjustmentPeriod", EmitDefaultValue=false)]
		public BooleanValue? AdjustmentPeriod { get; set; }

		[DataMember(Name="ClosedInAP", EmitDefaultValue=false)]
		public BooleanValue? ClosedInAP { get; set; }

		[DataMember(Name="ClosedInAR", EmitDefaultValue=false)]
		public BooleanValue? ClosedInAR { get; set; }

		[DataMember(Name="ClosedInCA", EmitDefaultValue=false)]
		public BooleanValue? ClosedInCA { get; set; }

		[DataMember(Name="ClosedInFA", EmitDefaultValue=false)]
		public BooleanValue? ClosedInFA { get; set; }

		[DataMember(Name="ClosedInIN", EmitDefaultValue=false)]
		public BooleanValue? ClosedInIN { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateOnlyValue? EndDate { get; set; }

		[DataMember(Name="FinancialPeriodID", EmitDefaultValue=false)]
		public StringValue? FinancialPeriodID { get; set; }

		[DataMember(Name="LengthInDays", EmitDefaultValue=false)]
		public IntValue? LengthInDays { get; set; }

		[DataMember(Name="PeriodNbr", EmitDefaultValue=false)]
		public StringValue? PeriodNbr { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateOnlyValue? StartDate { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}