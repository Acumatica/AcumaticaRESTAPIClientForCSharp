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
	public class TaxCodeSetting : Entity
	{

		[DataMember(Name="AdditionalInformation", EmitDefaultValue=false)]
		public StringValue? AdditionalInformation { get; set; }

		[DataMember(Name="CompanyNotes", EmitDefaultValue=false)]
		public StringValue? CompanyNotes { get; set; }

		[DataMember(Name="FormBox", EmitDefaultValue=false)]
		public StringValue? FormBox { get; set; }

		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue? Required { get; set; }

		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

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