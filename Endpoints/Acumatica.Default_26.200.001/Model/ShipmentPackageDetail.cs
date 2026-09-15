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
	public class ShipmentPackageDetail : Entity
	{

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		[DataMember(Name="OrigOrderNbr", EmitDefaultValue=false)]
		public StringValue? OrigOrderNbr { get; set; }

		[DataMember(Name="OrigOrderType", EmitDefaultValue=false)]
		public StringValue? OrigOrderType { get; set; }

		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		[DataMember(Name="ShipmentSplitLineNbr", EmitDefaultValue=false)]
		public IntValue? ShipmentSplitLineNbr { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

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