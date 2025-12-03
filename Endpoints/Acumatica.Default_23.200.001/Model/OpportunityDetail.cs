using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class OpportunityDetail : Entity
	{

		/// <summary>
		/// The currency of the opportunity.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
		public StringValue? DisplayName { get; set; }

		/// <summary>
		/// The estimated date of closing the deal.
		/// <para>DAC Field Name: CloseDate</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Estimated Close Date</para>
		/// </summary>
		[DataMember(Name="Estimation", EmitDefaultValue=false)]
		public DateTimeValue? Estimation { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CROpportunityProbability__Probability</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		[DataMember(Name="Probability", EmitDefaultValue=false)]
		public IntValue? Probability { get; set; }

		/// <summary>
		/// The current stage of the opportunity.
		/// <para>DAC Field Name: StageID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>SQL Type: varchar(2)</para>
		/// </summary>
		[DataMember(Name="Stage", EmitDefaultValue=false)]
		public StringValue? Stage { get; set; }

		/// <summary>
		/// The status of the contact.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The subject or description of the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryProductsAmount</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		[DataMember(Name="Total", EmitDefaultValue=false)]
		public DecimalValue? Total { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// <para>DAC Field Name: WorkgroupID</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

	}
}