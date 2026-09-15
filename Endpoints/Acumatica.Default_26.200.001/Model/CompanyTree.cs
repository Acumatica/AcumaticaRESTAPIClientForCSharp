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
	public class CompanyTree : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Specifies whether the member is the owner of the workgroup.
		/// <para>DAC Field Name: IsOwner</para>
		/// <para>DAC: PX.TM.EPCompanyTreeMember</para>
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public BooleanValue? Owner { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// <para>DAC: PX.Objects.CR.CRPMTimeActivity</para>
		/// <para>Display Name: Workgroup</para>
		/// </summary>
		[DataMember(Name="WorkgroupID", EmitDefaultValue=false)]
		public StringValue? WorkgroupID { get; set; }

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