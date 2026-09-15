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
		public StringSingleSelectValue? MailStatus { get; set; }

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