using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class TaxSettingDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeAttribute 
		/// Display Name: Additional Information 
		/// SQL Type: nvarchar(2048) 
		/// </summary>
		[DataMember(Name="AdditionalInformation", EmitDefaultValue=false)]
		public StringValue? AdditionalInformation { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeAttribute 
		/// Display Name: Company Notes 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="CompanyNotes", EmitDefaultValue=false)]
		public StringValue? CompanyNotes { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeAttribute 
		/// Display Name: Form/Box 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="FormBox", EmitDefaultValue=false)]
		public StringValue? FormBox { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.PR.PREmployeeAttribute 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeAttribute 
		/// </summary>
		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue? Required { get; set; }

		[DataMember(Name="Setting", EmitDefaultValue=false)]
		public StringValue? Setting { get; set; }

		/// <summary>
		/// The string identifier of the state or province part of the address.
		/// DAC: PX.Objects.CR.Address 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeAttribute 
		/// Display Name: Use Default 
		/// </summary>
		[DataMember(Name="UseDefault", EmitDefaultValue=false)]
		public BooleanValue? UseDefault { get; set; }

		/// <summary>
		/// DAC Field Name: UsedForGovernmentReporting 
		/// DAC: PX.Objects.PR.PREmployeeAttribute 
		/// Display Name: Used for Government Reporting 
		/// </summary>
		[DataMember(Name="UsedforGovernmentReporting", EmitDefaultValue=false)]
		public BooleanValue? UsedforGovernmentReporting { get; set; }

		/// <summary>
		/// DAC Field Name: UsedForTaxCalculation 
		/// DAC: PX.Objects.PR.PREmployeeAttribute 
		/// Display Name: Used for Tax Calculation 
		/// </summary>
		[DataMember(Name="UsedforTaxCalculation", EmitDefaultValue=false)]
		public BooleanValue? UsedforTaxCalculation { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeAttribute 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}