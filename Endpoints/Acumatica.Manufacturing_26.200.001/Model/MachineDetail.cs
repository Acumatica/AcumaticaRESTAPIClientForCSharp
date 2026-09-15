using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	[DataContract]
	public class MachineDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: MachAcctID</para>
		/// <para>DAC: PX.Objects.AM.AMWCMach</para>
		/// <para>Display Name: Machine Account</para>
		/// </summary>
		[DataMember(Name="MachineAccount", EmitDefaultValue=false)]
		public StringValue? MachineAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachID</para>
		/// <para>DAC: PX.Objects.AM.AMWCMach</para>
		/// <para>Display Name: Machine ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="MachineID", EmitDefaultValue=false)]
		public StringValue? MachineID { get; set; }

		/// <summary>
		/// Indicates if the machine record will be used (false value) or should the workcenter machine record be used as overriding values (true value)
		/// <para>DAC: PX.Objects.AM.AMWCMach</para>
		/// <para>Display Name: Machine Override</para>
		/// </summary>
		[DataMember(Name="MachineOverride", EmitDefaultValue=false)]
		public BooleanValue? MachineOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachSubID</para>
		/// <para>DAC: PX.Objects.AM.AMWCMach</para>
		/// <para>Display Name: Machine Subaccount</para>
		/// </summary>
		[DataMember(Name="MachineSubaccount", EmitDefaultValue=false)]
		public StringValue? MachineSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.AM.AMWCMach</para>
		/// <para>Display Name: Standard Cost</para>
		/// </summary>
		[DataMember(Name="StandardCost", EmitDefaultValue=false)]
		public DecimalValue? StandardCost { get; set; }

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