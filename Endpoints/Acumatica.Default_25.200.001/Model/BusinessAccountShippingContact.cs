using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class BusinessAccountShippingContact : Entity
	{

		/// <summary>
		/// The name of the document recipient (a person or team) used in the documents.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		/// <remarks>
		/// Not used in primary graph, only in documents, for instance, CROpportunity, SOOrder, and so on.
		/// </remarks>
		public StringValue? Attention { get; set; }

		/// <summary>
		/// The email address of the contact.
		/// <para>DAC Field Name: EMail</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Email { get; set; }

		/// <summary>
		/// The fax number.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? Fax { get; set; }

		/// <summary>
		/// The job title of the person.
		/// <para>DAC Field Name: Salutation</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Job Title</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? JobTitle { get; set; }

		/// <summary>
		/// The phone number.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Phone 1</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// The second phone number.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Phone 2</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? Phone2 { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Contact record, which isreferenced by DefContactID.
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// </summary>
		public BooleanValue? Override { get; set; }

	}
}