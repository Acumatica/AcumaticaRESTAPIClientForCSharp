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
	public class ChangeRequestMarkup : Entity
	{

		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue? AccountGroup { get; set; }

		[DataMember(Name="AmountSubjectToMarkup", EmitDefaultValue=false)]
		public DecimalValue? AmountSubjectToMarkup { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="MarkupAmount", EmitDefaultValue=false)]
		public DecimalValue? MarkupAmount { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="Value", EmitDefaultValue=false)]
		public DecimalValue? Value { get; set; }

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