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
	public class WorkOrderShipmentDetail : Entity
	{

		[DataMember(Name="InvtDocType", EmitDefaultValue=false)]
		public StringValue? InvtDocType { get; set; }

		[DataMember(Name="InvtRefNbr", EmitDefaultValue=false)]
		public StringValue? InvtRefNbr { get; set; }

		[DataMember(Name="ShipDate", EmitDefaultValue=false)]
		public DateOnlyValue? ShipDate { get; set; }

		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue? ShipmentNbr { get; set; }

		[DataMember(Name="ShippedQty", EmitDefaultValue=false)]
		public DecimalValue? ShippedQty { get; set; }

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