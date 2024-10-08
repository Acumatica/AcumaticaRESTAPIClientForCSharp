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
	public class ProjectAddress : Entity
	{

		/// <summary>
		/// The first address line.
		/// DAC: PX.Objects.PM.PMAddress 
		/// Display Name: Address Line 1 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="AddressLine1", EmitDefaultValue=false)]
		public StringValue? AddressLine1 { get; set; }

		/// <summary>
		/// The name of the city or inhabited locality.
		/// DAC: PX.Objects.PM.PMAddress 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="City", EmitDefaultValue=false)]
		public StringValue? City { get; set; }

		/// <summary>
		/// The identifier of the Country record.
		/// DAC Field Name: CountryId 
		/// DAC: PX.Objects.PM.PMSiteAddress 
		/// SQL Type: nvarchar(2) 
		/// </summary>
		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		/// <summary>
		/// The name of the state.
		/// DAC: PX.Objects.PM.PMAddress 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

		/// <summary>
		/// The postal code.
		/// DAC: PX.Objects.PM.PMAddress 
		/// Display Name: Postal Code 
		/// SQL Type: varchar(20) 
		/// </summary>
		[DataMember(Name="PostalCode", EmitDefaultValue=false)]
		public StringValue? PostalCode { get; set; }

		/// <summary>
		/// The latitude of the address.
		/// DAC: PX.Objects.PM.PMSiteAddress 
		/// </summary>
		[DataMember(Name="Latitude", EmitDefaultValue=false)]
		public DecimalValue? Latitude { get; set; }

		/// <summary>
		/// The longitude of the address.
		/// DAC: PX.Objects.PM.PMSiteAddress 
		/// </summary>
		[DataMember(Name="Longitude", EmitDefaultValue=false)]
		public DecimalValue? Longitude { get; set; }

	}
}