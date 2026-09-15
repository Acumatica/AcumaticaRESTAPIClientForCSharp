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
	public class EngineeringChangeOrderTool : Entity
	{

		[DataMember(Name="ChangeStatus", EmitDefaultValue=false)]
		public StringValue? ChangeStatus { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="ECOID", EmitDefaultValue=false)]
		public StringValue? ECOID { get; set; }

		[DataMember(Name="LineID", EmitDefaultValue=false)]
		public IntValue? LineID { get; set; }

		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public DecimalValue? QtyRequired { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		[DataMember(Name="ToolID", EmitDefaultValue=false)]
		public StringValue? ToolID { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

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