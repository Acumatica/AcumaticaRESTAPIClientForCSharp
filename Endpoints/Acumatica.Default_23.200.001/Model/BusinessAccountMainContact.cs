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
	public class BusinessAccountMainContact : Entity
	{

		/// <summary>
		/// The name of the document recipient (a person or team) used in the documents.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		/// <remarks>
		/// Not used in primary graph, only in documents, for instance, CROpportunity, SOOrder, and so on.
		/// </remarks>
		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue? Attention { get; set; }

		/// <summary>
		/// The name of the company the contact works for.
		/// <para>DAC Field Name: FullName</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Account Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// The email address of the contact.
		/// <para>DAC Field Name: EMail</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// The fax number.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="Fax", EmitDefaultValue=false)]
		public StringValue? Fax { get; set; }

		/// <summary>
		/// The job title of the person.
		/// <para>DAC Field Name: Salutation</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Job Title</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="JobTitle", EmitDefaultValue=false)]
		public StringValue? JobTitle { get; set; }

		/// <summary>
		/// The language in which the contact prefers to communicate.
		/// <para>DAC Field Name: LanguageID</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Language/Locale</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="LanguageOrLocale", EmitDefaultValue=false)]
		public StringValue? LanguageOrLocale { get; set; }

		/// <summary>
		/// The phone number.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Phone 1</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// The second phone number.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Phone 2</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue? Phone2 { get; set; }

		/// <summary>
		/// The URL of the contact website.
		/// <para>DAC Field Name: WebSite</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Web", EmitDefaultValue=false)]
		public StringValue? Web { get; set; }

	}
}