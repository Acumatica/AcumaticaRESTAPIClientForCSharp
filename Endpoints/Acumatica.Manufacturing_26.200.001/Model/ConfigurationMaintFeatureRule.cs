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
	public class ConfigurationMaintFeatureRule : Entity
	{

		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue? ConfigurationID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		[DataMember(Name="Rule", EmitDefaultValue=false)]
		public StringValue? Rule { get; set; }

		[DataMember(Name="RuleSource", EmitDefaultValue=false)]
		public StringValue? RuleSource { get; set; }

		[DataMember(Name="SourceLineNbr", EmitDefaultValue=false)]
		public IntValue? SourceLineNbr { get; set; }

		[DataMember(Name="SourceOption", EmitDefaultValue=false)]
		public StringValue? SourceOption { get; set; }

		[DataMember(Name="TargetFeature", EmitDefaultValue=false)]
		public StringValue? TargetFeature { get; set; }

		[DataMember(Name="TargetOption", EmitDefaultValue=false)]
		public StringValue? TargetOption { get; set; }

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