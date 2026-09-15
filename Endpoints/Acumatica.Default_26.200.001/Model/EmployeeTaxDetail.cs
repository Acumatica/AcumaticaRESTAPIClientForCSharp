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
	public class EmployeeTaxDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeTax</para>
		/// <para>Display Name: Tax Code</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxCode", EmitDefaultValue=false)]
		public StringValue? TaxCode { get; set; }

		[DataMember(Name="TaxCodeSettings", EmitDefaultValue=false)]
		public List<TaxCodeSetting>? TaxCodeSettings { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxID_Description</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeTax</para>
		/// </summary>
		[DataMember(Name="TaxDescription", EmitDefaultValue=false)]
		public StringValue? TaxDescription { get; set; }

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
			public const string TaxCodeSettings = "TaxCodeSettings";

			//Intentionally excluded
			//public const string All = "Files,TaxCodeSettings";
		}
	}
}