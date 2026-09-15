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
	public class ServiceLocationCustomerDetail : Entity
	{

		[DataMember(Name="City", EmitDefaultValue=false)]
		public StringValue? City { get; set; }

		[DataMember(Name="CustomerClassID", EmitDefaultValue=false)]
		public StringValue? CustomerClassID { get; set; }

		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		[DataMember(Name="CustomerLocationID", EmitDefaultValue=false)]
		public StringValue? CustomerLocationID { get; set; }

		[DataMember(Name="CustomerStatus", EmitDefaultValue=false)]
		public StringValue? CustomerStatus { get; set; }

		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

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