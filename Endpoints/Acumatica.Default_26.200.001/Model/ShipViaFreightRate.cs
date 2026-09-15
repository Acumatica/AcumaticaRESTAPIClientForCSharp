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
	public class ShipViaFreightRate : Entity
	{

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.FreightRate</para>
		/// </summary>
		[DataMember(Name="Rate", EmitDefaultValue=false)]
		public DecimalValue? Rate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.FreightRate</para>
		/// </summary>
		[DataMember(Name="Volume", EmitDefaultValue=false)]
		public DecimalValue? Volume { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.FreightRate</para>
		/// </summary>
		[DataMember(Name="Weight", EmitDefaultValue=false)]
		public DecimalValue? Weight { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.FreightRate</para>
		/// <para>Display Name: Zone ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ZoneID", EmitDefaultValue=false)]
		public StringValue? ZoneID { get; set; }

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