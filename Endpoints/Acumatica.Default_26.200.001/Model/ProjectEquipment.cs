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
	public class ProjectEquipment : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EquipmentID", EmitDefaultValue=false)]
		public StringValue? EquipmentID { get; set; }

		[DataMember(Name="RunRate", EmitDefaultValue=false)]
		public DecimalValue? RunRate { get; set; }

		[DataMember(Name="RunRateItem", EmitDefaultValue=false)]
		public StringValue? RunRateItem { get; set; }

		[DataMember(Name="SetupRate", EmitDefaultValue=false)]
		public DecimalValue? SetupRate { get; set; }

		[DataMember(Name="SetupRateItem", EmitDefaultValue=false)]
		public StringValue? SetupRateItem { get; set; }

		[DataMember(Name="SuspendRate", EmitDefaultValue=false)]
		public DecimalValue? SuspendRate { get; set; }

		[DataMember(Name="SuspendRateItem", EmitDefaultValue=false)]
		public StringValue? SuspendRateItem { get; set; }

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