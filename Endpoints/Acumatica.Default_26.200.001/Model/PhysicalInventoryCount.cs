using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN305010</c> in the Acumatica ERP
	/// <para>Key Fields: ReferenceNbr</para>
	/// </summary>
	[DataContract]
	public class PhysicalInventoryCount : Entity, ITopLevelEntity
	{

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<PhysicalInventoryCountDetail>? Details { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.PICountFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.IN.PICountFilter</para>
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.PICountFilter</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PIID</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

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
			public const string Translations = "Translations";
			public const string Details = "Details";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}