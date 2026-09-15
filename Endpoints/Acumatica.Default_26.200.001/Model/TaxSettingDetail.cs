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
	public class TaxSettingDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeAttribute</para>
		/// <para>Display Name: Additional Information</para>
		/// <para>SQL Type: nvarchar(2048)</para>
		/// </summary>
		[DataMember(Name="AdditionalInformation", EmitDefaultValue=false)]
		public StringValue? AdditionalInformation { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeAttribute</para>
		/// <para>Display Name: Company Notes</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="CompanyNotes", EmitDefaultValue=false)]
		public StringValue? CompanyNotes { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeAttribute</para>
		/// <para>Display Name: Form/Box</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="FormBox", EmitDefaultValue=false)]
		public StringValue? FormBox { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Description</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeAttribute</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeAttribute</para>
		/// </summary>
		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue? Required { get; set; }

		[DataMember(Name="Setting", EmitDefaultValue=false)]
		public StringValue? Setting { get; set; }

		[DataMember(Name="SettingLevel", EmitDefaultValue=false)]
		public StringValue? SettingLevel { get; set; }

		/// <summary>
		/// The string identifier of the state or province part of the address.
		/// <para>DAC: PX.Objects.CR.Address</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UsedForGovernmentReporting</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeAttribute</para>
		/// <para>Display Name: Used for Government Reporting</para>
		/// </summary>
		[DataMember(Name="UsedforGovernmentReporting", EmitDefaultValue=false)]
		public BooleanValue? UsedforGovernmentReporting { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UsedForTaxCalculation</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeAttribute</para>
		/// <para>Display Name: Used for Tax Calculation</para>
		/// </summary>
		[DataMember(Name="UsedforTaxCalculation", EmitDefaultValue=false)]
		public BooleanValue? UsedforTaxCalculation { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeAttribute</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

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