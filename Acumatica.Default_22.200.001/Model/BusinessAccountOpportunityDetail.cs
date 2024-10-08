using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class BusinessAccountOpportunityDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: BAccount__AcctCD 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="BusinessAccountID", EmitDefaultValue=false)]
		public StringValue? BusinessAccountID { get; set; }

		/// <summary>
		/// DAC Field Name: BAccount__AcctName 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
		public StringValue? BusinessAccountName { get; set; }

		/// <summary>
		/// The identifier of the Currency,which is applied to the documents of the business account.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: Contact__DisplayName 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
		public StringValue? DisplayName { get; set; }

		/// <summary>
		/// The estimated date of closing the deal.
		/// DAC Field Name: CloseDate 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Estimated Close Date 
		/// </summary>
		[DataMember(Name="Estimation", EmitDefaultValue=false)]
		public DateTimeValue? Estimation { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// DAC Field Name: CROpportunityProbability__Probability 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="Probability", EmitDefaultValue=false)]
		public IntValue? Probability { get; set; }

		/// <summary>
		/// The current stage of the opportunity.
		/// DAC Field Name: StageID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// SQL Type: varchar(2) 
		/// </summary>
		[DataMember(Name="Stage", EmitDefaultValue=false)]
		public StringValue? Stage { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Customer Status 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The subject or description of the opportunity.
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Description 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		/// <summary>
		/// DAC Field Name: CuryProductsAmount 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="Total", EmitDefaultValue=false)]
		public DecimalValue? Total { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

	}
}