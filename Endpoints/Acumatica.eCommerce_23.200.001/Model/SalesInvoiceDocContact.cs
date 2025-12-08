using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class SalesInvoiceDocContact : Entity
	{

		/// <summary>
		/// The attention for this contact.
		/// <para>DAC: PX.Objects.AR.ARShippingContact</para>
		/// <para>SQL Type: nvarchar(2500)</para>
		/// </summary>
		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue? Attention { get; set; }

		/// <summary>
		/// The business name or the company name of the contact.
		/// <para>DAC Field Name: FullName</para>
		/// <para>DAC: PX.Objects.AR.ARShippingContact</para>
		/// <para>Display Name: Account Name</para>
		/// <para>SQL Type: nvarchar(2500)</para>
		/// </summary>
		[DataMember(Name="BusinessName", EmitDefaultValue=false)]
		public StringValue? BusinessName { get; set; }

		/// <summary>
		/// The e-mail address of the contact.
		/// <para>DAC: PX.Objects.AR.ARShippingContact</para>
		/// <para>SQL Type: nvarchar(2500)</para>
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// The first phone number of the contact.
		/// <para>DAC: PX.Objects.AR.ARShippingContact</para>
		/// <para>Display Name: Phone 1</para>
		/// <para>SQL Type: varchar(2500)</para>
		/// </summary>
		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

	}
}