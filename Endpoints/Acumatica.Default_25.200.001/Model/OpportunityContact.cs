using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class OpportunityContact : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRShippingContact</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Attention { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FullName</para>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Account Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EMail</para>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>SQL Type: varchar(255)</para>
		/// </summary>
		public StringValue? Email { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>SQL Type: varchar(50)</para>
		/// </summary>
		public StringValue? Fax { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Fax</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		public StringValue? FaxType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: First Name</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? FirstName { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Last Name</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? LastName { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Phone 1</para>
		/// <para>SQL Type: varchar(50)</para>
		/// </summary>
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Phone 1</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		public StringValue? Phone1Type { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Phone 2</para>
		/// <para>SQL Type: varchar(50)</para>
		/// </summary>
		public StringValue? Phone2 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Phone 2</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		public StringValue? Phone2Type { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Phone 3</para>
		/// <para>SQL Type: varchar(50)</para>
		/// </summary>
		public StringValue? Phone3 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Phone 3</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		public StringValue? Phone3Type { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Salutation</para>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Job Title</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Position { get; set; }

		public StringValue? Title { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Web</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? WebSite { get; set; }

	}
}