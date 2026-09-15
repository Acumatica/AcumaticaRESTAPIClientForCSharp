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
	public class EmployeeDeductionOrBenefitDetail : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="ContributionAmount", EmitDefaultValue=false)]
		public DecimalValue? ContributionAmount { get; set; }

		[DataMember(Name="ContributionMax", EmitDefaultValue=false)]
		public DecimalValue? ContributionMax { get; set; }

		[DataMember(Name="ContributionMaximumFrequency", EmitDefaultValue=false)]
		public StringValue? ContributionMaximumFrequency { get; set; }

		[DataMember(Name="ContributionPercent", EmitDefaultValue=false)]
		public DecimalValue? ContributionPercent { get; set; }

		[DataMember(Name="DeductionAmount", EmitDefaultValue=false)]
		public DecimalValue? DeductionAmount { get; set; }

		[DataMember(Name="DeductionCode", EmitDefaultValue=false)]
		public StringValue? DeductionCode { get; set; }

		[DataMember(Name="DeductionMax", EmitDefaultValue=false)]
		public DecimalValue? DeductionMax { get; set; }

		[DataMember(Name="DeductionMaximumFrequency", EmitDefaultValue=false)]
		public StringValue? DeductionMaximumFrequency { get; set; }

		[DataMember(Name="DeductionPercent", EmitDefaultValue=false)]
		public DecimalValue? DeductionPercent { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		[DataMember(Name="GarnishmentDetails", EmitDefaultValue=false)]
		public GarnishmentDetails? GarnishmentDetails { get; set; }

		[DataMember(Name="IsGarnish", EmitDefaultValue=false)]
		public BooleanValue? IsGarnish { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Sequence", EmitDefaultValue=false)]
		public IntValue? Sequence { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="UseContributionDefaults", EmitDefaultValue=false)]
		public BooleanValue? UseContributionDefaults { get; set; }

		[DataMember(Name="UseDeductionDefaults", EmitDefaultValue=false)]
		public BooleanValue? UseDeductionDefaults { get; set; }

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
			public const string GarnishmentDetails = "GarnishmentDetails";

			//Intentionally excluded
			//public const string All = "Files,GarnishmentDetails";
		}
	}
}