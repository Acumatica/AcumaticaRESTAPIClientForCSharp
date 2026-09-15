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
	public class WCCCodeRate : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="BenefitCalculationMethod", EmitDefaultValue=false)]
		public StringValue? BenefitCalculationMethod { get; set; }

		[DataMember(Name="BenefitRate", EmitDefaultValue=false)]
		public DecimalValue? BenefitRate { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		[DataMember(Name="DeductionCalculationMethod", EmitDefaultValue=false)]
		public StringValue? DeductionCalculationMethod { get; set; }

		[DataMember(Name="DeductionCode", EmitDefaultValue=false)]
		public StringValue? DeductionCode { get; set; }

		[DataMember(Name="DeductionRate", EmitDefaultValue=false)]
		public DecimalValue? DeductionRate { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

		[DataMember(Name="WorkCodeID", EmitDefaultValue=false)]
		public StringValue? WorkCodeID { get; set; }

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