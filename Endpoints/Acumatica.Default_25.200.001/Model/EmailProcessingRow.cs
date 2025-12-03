using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class EmailProcessingRow : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: EMailAccount__Description</para>
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// </summary>
		[DataMember(Name="EmailAccount", EmitDefaultValue=false)]
		public StringValue? EmailAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MailFrom</para>
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// <para>SQL Type: nvarchar(500)</para>
		/// </summary>
		[DataMember(Name="From", EmitDefaultValue=false)]
		public StringValue? From { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MPStatus</para>
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// <para>Display Name: Email Status</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="MailStatus", EmitDefaultValue=false)]
		public StringValue? MailStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CRActivity__OwnerID</para>
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CRActivity__StartDate</para>
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// <para>Display Name: Summary</para>
		/// <para>SQL Type: nvarchar(998)</para>
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MailTo</para>
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// <para>SQL Type: nvarchar(3000)</para>
		/// </summary>
		[DataMember(Name="To", EmitDefaultValue=false)]
		public StringValue? To { get; set; }

	}
}