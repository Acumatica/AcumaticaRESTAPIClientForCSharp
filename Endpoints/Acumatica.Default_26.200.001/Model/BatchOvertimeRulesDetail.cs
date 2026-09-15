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
	public class BatchOvertimeRulesDetail : Entity
	{

		[DataMember(Name="DayofWeek", EmitDefaultValue=false)]
		public StringValue? DayofWeek { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DisbursingEarningType", EmitDefaultValue=false)]
		public StringValue? DisbursingEarningType { get; set; }

		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue? Enabled { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Multiplier", EmitDefaultValue=false)]
		public DecimalValue? Multiplier { get; set; }

		[DataMember(Name="OvertimeRule", EmitDefaultValue=false)]
		public StringValue? OvertimeRule { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

		[DataMember(Name="ThresholdforOvertimehours", EmitDefaultValue=false)]
		public DecimalValue? ThresholdforOvertimehours { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="UnionLocal", EmitDefaultValue=false)]
		public StringValue? UnionLocal { get; set; }

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