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
	public class EmailProcessingRow : Entity
	{

		/// <summary>
		/// DAC Field Name: EMailAccount__Description 
		/// DAC: PX.Objects.CR.SMEmail 
		/// </summary>
		[DataMember(Name="EmailAccount", EmitDefaultValue=false)]
		public StringValue? EmailAccount { get; set; }

		/// <summary>
		/// DAC Field Name: MailFrom 
		/// DAC: PX.Objects.CR.SMEmail 
		/// SQL Type: nvarchar(500) 
		/// </summary>
		[DataMember(Name="From", EmitDefaultValue=false)]
		public StringValue? From { get; set; }

		/// <summary>
		/// DAC Field Name: MPStatus 
		/// DAC: PX.Objects.CR.SMEmail 
		/// Display Name: Email Status 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="MailStatus", EmitDefaultValue=false)]
		public StringValue? MailStatus { get; set; }

		/// <summary>
		/// DAC Field Name: CRActivity__OwnerID 
		/// DAC: PX.Objects.CR.SMEmail 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// DAC: PX.Objects.CR.SMEmail 
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// DAC Field Name: CRActivity__StartDate 
		/// DAC: PX.Objects.CR.SMEmail 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.SMEmail 
		/// Display Name: Summary 
		/// SQL Type: nvarchar(998) 
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		/// <summary>
		/// DAC Field Name: MailTo 
		/// DAC: PX.Objects.CR.SMEmail 
		/// SQL Type: nvarchar(3000) 
		/// </summary>
		[DataMember(Name="To", EmitDefaultValue=false)]
		public StringValue? To { get; set; }

	}
}