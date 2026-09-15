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
	public class EmployeeDelegate : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: WingmanID</para>
		/// <para>DAC: PX.Objects.EP.EPWingman</para>
		/// <para>Display Name: Delegated To</para>
		/// </summary>
		[DataMember(Name="Delegate", EmitDefaultValue=false)]
		public StringValue? Delegate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WingmanID_EPEmployee_acctName</para>
		/// <para>DAC: PX.Objects.EP.EPWingman</para>
		/// </summary>
		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		/// <summary>
		/// Represents the type of the delegation.
		/// <para>DAC: PX.Objects.EP.EPWingman</para>
		/// <para>Display Name: Delegation Of</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="DelegationOf", EmitDefaultValue=false)]
		public StringValue? DelegationOf { get; set; }

		/// <summary>
		/// Delegation start date
		/// <para>DAC: PX.Objects.EP.EPWingman</para>
		/// <para>Display Name: Starts On</para>
		/// </summary>
		[DataMember(Name="StartsOn", EmitDefaultValue=false)]
		public DateTimeValue? StartsOn { get; set; }

		/// <summary>
		/// Delegation end date
		/// <para>DAC: PX.Objects.EP.EPWingman</para>
		/// <para>Display Name: Expires On</para>
		/// </summary>
		[DataMember(Name="ExpiresOn", EmitDefaultValue=false)]
		public DateTimeValue? ExpiresOn { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.EPEmployeePosition</para>
		/// <para>Display Name: Active</para>
		/// </summary>
		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue? IsActive { get; set; }

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