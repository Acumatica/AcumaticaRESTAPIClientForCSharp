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
	public class ConfigurationEntryOptions : Entity
	{

		[DataMember(Name="ConfigResultsID", EmitDefaultValue=false)]
		public IntValue? ConfigResultsID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="FeatureLineNbr", EmitDefaultValue=false)]
		public IntValue? FeatureLineNbr { get; set; }

		[DataMember(Name="Included", EmitDefaultValue=false)]
		public BooleanValue? Included { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="IsRemovable", EmitDefaultValue=false)]
		public BooleanValue? IsRemovable { get; set; }

		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		[DataMember(Name="OptionLineNbr", EmitDefaultValue=false)]
		public IntValue? OptionLineNbr { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

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