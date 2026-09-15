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
	/// Corresponds to the screen <c>PM306500</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProjectMaterials : Entity, ITopLevelEntity
	{

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateOnlyValue? EndDate { get; set; }

		[DataMember(Name="MaterialLines", EmitDefaultValue=false)]
		public List<MaterialListLines>? MaterialLines { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="ProjectManager", EmitDefaultValue=false)]
		public StringValue? ProjectManager { get; set; }

		[DataMember(Name="QuoteRefNbr", EmitDefaultValue=false)]
		public StringValue? QuoteRefNbr { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateOnlyValue? StartDate { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public MaterialListTotals? Totals { get; set; }

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
			public const string MaterialLines = "MaterialLines";
			public const string Totals = "Totals";

			//Intentionally excluded
			//public const string All = "Files,Translations,MaterialLines,Totals";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}