using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmployeeTaxDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.PR.PREmployeeEarning 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: TaxID 
		/// DAC: PX.Objects.PR.PREmployeeTax 
		/// Display Name: Tax Code 
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxCode", EmitDefaultValue=false)]
		public StringValue? TaxCode { get; set; }

		[DataMember(Name="TaxCodeSettings", EmitDefaultValue=false)]
		public List<TaxCodeSetting>? TaxCodeSettings { get; set; }

		/// <summary>
		/// DAC Field Name: TaxID_Description 
		/// DAC: PX.Objects.PR.PREmployeeTax 
		/// </summary>
		[DataMember(Name="TaxDescription", EmitDefaultValue=false)]
		public StringValue? TaxDescription { get; set; }

	}
}