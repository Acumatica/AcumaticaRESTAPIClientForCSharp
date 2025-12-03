using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CS207510</c> in the Acumatica ERP
	/// <para>Key Fields: ZoneID</para>
	/// </summary>
	[DataContract]
	public class ShippingZones : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CS.ShippingZone</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.ShippingZone</para>
		/// <para>Display Name: Zone ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ZoneID", EmitDefaultValue=false)]
		public StringValue? ZoneID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}