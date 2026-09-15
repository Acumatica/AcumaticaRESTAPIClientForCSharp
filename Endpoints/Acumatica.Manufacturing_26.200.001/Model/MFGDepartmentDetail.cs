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
	public class MFGDepartmentDetail : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AllowClockEntryforMultipleProductionOrders", EmitDefaultValue=false)]
		public BooleanValue? AllowClockEntryforMultipleProductionOrders { get; set; }

		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue? BackflushLabor { get; set; }

		[DataMember(Name="BackflushMaterials", EmitDefaultValue=false)]
		public BooleanValue? BackflushMaterials { get; set; }

		[DataMember(Name="BasisforCapacity", EmitDefaultValue=false)]
		public StringValue? BasisforCapacity { get; set; }

		[DataMember(Name="ControlPoint", EmitDefaultValue=false)]
		public BooleanValue? ControlPoint { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcess { get; set; }

		[DataMember(Name="ScrapActionDefault", EmitDefaultValue=false)]
		public StringValue? ScrapActionDefault { get; set; }

		[DataMember(Name="StandardCost", EmitDefaultValue=false)]
		public DecimalValue? StandardCost { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue? WorkCenter { get; set; }

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