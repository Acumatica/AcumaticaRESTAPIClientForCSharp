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
	public class EmployeeDelegate : Entity
	{

		/// <summary>
		/// DAC Field Name: WingmanID 
		/// DAC: PX.Objects.EP.EPWingman 
		/// Display Name: Delegated To 
		/// </summary>
		[DataMember(Name="Delegate", EmitDefaultValue=false)]
		public StringValue? Delegate { get; set; }

		/// <summary>
		/// DAC Field Name: WingmanID_EPEmployee_acctName 
		/// DAC: PX.Objects.EP.EPWingman 
		/// </summary>
		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		/// <summary>
		/// Represents the type of the delegation.
		/// DAC: PX.Objects.EP.EPWingman 
		/// Display Name: Delegation Of 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="DelegationOf", EmitDefaultValue=false)]
		public StringValue? DelegationOf { get; set; }

		/// <summary>
		/// Delegation start date
		/// DAC: PX.Objects.EP.EPWingman 
		/// Display Name: Starts On 
		/// </summary>
		[DataMember(Name="StartsOn", EmitDefaultValue=false)]
		public DateTimeValue? StartsOn { get; set; }

		/// <summary>
		/// Delegation end date
		/// DAC: PX.Objects.EP.EPWingman 
		/// Display Name: Expires On 
		/// </summary>
		[DataMember(Name="ExpiresOn", EmitDefaultValue=false)]
		public DateTimeValue? ExpiresOn { get; set; }

		/// <summary>
		/// DAC: PX.Objects.EP.EPEmployeePosition 
		/// Display Name: Active 
		/// </summary>
		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue? IsActive { get; set; }

	}
}