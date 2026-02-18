using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	public class SalesInvoiceDocContact : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARShippingContact</para>
		/// <para>SQL Type: nvarchar(2500)</para>
		/// </summary>
		public StringValue? Attention { get; set; }

		/// <summary>
		/// The business name or the company name of the contact.
		/// <para>DAC Field Name: FullName</para>
		/// <para>DAC: PX.Objects.AR.ARShippingContact</para>
		/// <para>Display Name: Account Name</para>
		/// <para>SQL Type: nvarchar(2500)</para>
		/// </summary>
		public StringValue? BusinessName { get; set; }

		/// <summary>
		/// The e-mail address of the contact.
		/// <para>DAC: PX.Objects.AR.ARShippingContact</para>
		/// <para>SQL Type: nvarchar(2500)</para>
		/// </summary>
		public StringValue? Email { get; set; }

		/// <summary>
		/// The first phone number of the contact.
		/// <para>DAC: PX.Objects.AR.ARShippingContact</para>
		/// <para>Display Name: Phone 1</para>
		/// <para>SQL Type: varchar(2500)</para>
		/// </summary>
		public StringValue? Phone1 { get; set; }

	}
}