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
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		/// <remarks>
		/// Not used in primary graph, only in documents, for instance, CROpportunity, SOOrder, and so on.
		/// </remarks>
		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue? Attention { get; set; }

		/// <summary>
		/// The name of the company the contact works for.
		/// DAC Field Name: FullName 
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Account Name 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// The email address of the contact.
		/// DAC Field Name: EMail 
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// The fax number.
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Fax", EmitDefaultValue=false)]
		public StringValue? Fax { get; set; }

		/// <summary>
		/// The job title of the person.
		/// DAC Field Name: Salutation 
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Job Title 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="JobTitle", EmitDefaultValue=false)]
		public StringValue? JobTitle { get; set; }

		/// <summary>
		/// The language in which the contact prefers to communicate.
		/// DAC Field Name: LanguageID 
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Language/Locale 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="LanguageOrLocale", EmitDefaultValue=false)]
		public StringValue? LanguageOrLocale { get; set; }

		/// <summary>
		/// The phone number.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Phone 1 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// The second phone number.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Phone 2 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue? Phone2 { get; set; }

		/// <summary>
		/// The URL of the contact website.
		/// DAC Field Name: WebSite 
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Web", EmitDefaultValue=false)]
		public StringValue? Web { get; set; }

	}
}