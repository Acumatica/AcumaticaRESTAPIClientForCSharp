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
	public class LeadOpportunity : Entity
	{

		/// <summary>
		/// The identifier of the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Opportunity ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		/// <remarks>
		/// This field depends on opportunityNumberingID.
		/// </remarks>
		[DataMember(Name="OpportunityID", EmitDefaultValue=false)]
		public StringValue? OpportunityID { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The current stage of the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Stage</para>
		/// <para>SQL Type: varchar(2)</para>
		/// </summary>
		[DataMember(Name="StageID", EmitDefaultValue=false)]
		public StringValue? StageID { get; set; }

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