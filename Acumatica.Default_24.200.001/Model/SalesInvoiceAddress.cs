using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class SalesInvoiceAddress : Entity
	{

		/// <summary>
		/// The first address line.
		/// DAC: PX.Objects.AR.ARShippingAddress 
		/// Display Name: Address Line 1 
		/// SQL Type: nvarchar(2500) 
		/// </summary>
		[DataMember(Name="AddressLine1", EmitDefaultValue=false)]
		public StringValue? AddressLine1 { get; set; }

		/// <summary>
		/// The second address line.
		/// DAC: PX.Objects.AR.ARShippingAddress 
		/// Display Name: Address Line 2 
		/// SQL Type: nvarchar(2500) 
		/// </summary>
		[DataMember(Name="AddressLine2", EmitDefaultValue=false)]
		public StringValue? AddressLine2 { get; set; }

		/// <summary>
		/// The name of the city or inhabited locality.
		/// DAC: PX.Objects.AR.ARShippingAddress 
		/// SQL Type: nvarchar(2500) 
		/// </summary>
		[DataMember(Name="City", EmitDefaultValue=false)]
		public StringValue? City { get; set; }

		/// <summary>
		/// The identifier of the Country record.
		/// DAC Field Name: CountryID 
		/// DAC: PX.Objects.AR.ARShippingAddress 
		/// SQL Type: nvarchar(2500) 
		/// </summary>
		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		/// <summary>
		/// The postal code.
		/// DAC: PX.Objects.AR.ARShippingAddress 
		/// Display Name: Postal Code 
		/// SQL Type: varchar(2500) 
		/// </summary>
		[DataMember(Name="PostalCode", EmitDefaultValue=false)]
		public StringValue? PostalCode { get; set; }

		/// <summary>
		/// The name of the state.
		/// DAC: PX.Objects.AR.ARShippingAddress 
		/// SQL Type: nvarchar(2500) 
		/// </summary>
		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

	}
}