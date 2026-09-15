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
	public class Approval : Entity
	{

		[DataMember(Name="ApprovedBy", EmitDefaultValue=false)]
		public StringValue? ApprovedBy { get; set; }

		[DataMember(Name="ApprovedByName", EmitDefaultValue=false)]
		public StringValue? ApprovedByName { get; set; }

		[DataMember(Name="Approver", EmitDefaultValue=false)]
		public StringValue? Approver { get; set; }

		[DataMember(Name="ApproverName", EmitDefaultValue=false)]
		public StringValue? ApproverName { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

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