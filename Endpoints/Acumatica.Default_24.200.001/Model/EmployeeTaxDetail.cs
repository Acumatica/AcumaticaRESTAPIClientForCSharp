using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
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

	}
}