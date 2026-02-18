using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class EmailProcessingRow : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: EMailAccount__Description</para>
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// </summary>
		public StringValue? EmailAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MailFrom</para>
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// <para>SQL Type: nvarchar(500)</para>
		/// </summary>
		public StringValue? From { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MPStatus</para>
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// <para>Display Name: Email Status</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? MailStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CRActivity__OwnerID</para>
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// </summary>
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CRActivity__StartDate</para>
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// <para>Display Name: Summary</para>
		/// <para>SQL Type: nvarchar(998)</para>
		/// </summary>
		public StringValue? Subject { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MailTo</para>
		/// <para>DAC: PX.Objects.CR.SMEmail</para>
		/// <para>SQL Type: nvarchar(3000)</para>
		/// </summary>
		public StringValue? To { get; set; }

	}
}