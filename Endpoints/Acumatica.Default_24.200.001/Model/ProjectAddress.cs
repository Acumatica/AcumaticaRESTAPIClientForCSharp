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
	public class ProjectAddress : Entity
	{

		/// <summary>
		/// The first address line.
		/// <para>DAC: PX.Objects.PM.PMAddress</para>
		/// <para>Display Name: Address Line 1</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="AddressLine1", EmitDefaultValue=false)]
		public StringValue? AddressLine1 { get; set; }

		/// <summary>
		/// The name of the city or inhabited locality.
		/// <para>DAC: PX.Objects.PM.PMAddress</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="City", EmitDefaultValue=false)]
		public StringValue? City { get; set; }

		/// <summary>
		/// The identifier of the Country record.
		/// <para>DAC Field Name: CountryId</para>
		/// <para>DAC: PX.Objects.PM.PMSiteAddress</para>
		/// <para>SQL Type: nvarchar(2)</para>
		/// </summary>
		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		/// <summary>
		/// The name of the state.
		/// <para>DAC: PX.Objects.PM.PMAddress</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

		/// <summary>
		/// The postal code.
		/// <para>DAC: PX.Objects.PM.PMAddress</para>
		/// <para>Display Name: Postal Code</para>
		/// <para>SQL Type: varchar(20)</para>
		/// </summary>
		[DataMember(Name="PostalCode", EmitDefaultValue=false)]
		public StringValue? PostalCode { get; set; }

		/// <summary>
		/// The latitude of the address.
		/// <para>DAC: PX.Objects.PM.PMSiteAddress</para>
		/// </summary>
		[DataMember(Name="Latitude", EmitDefaultValue=false)]
		public DecimalValue? Latitude { get; set; }

		/// <summary>
		/// The longitude of the address.
		/// <para>DAC: PX.Objects.PM.PMSiteAddress</para>
		/// </summary>
		[DataMember(Name="Longitude", EmitDefaultValue=false)]
		public DecimalValue? Longitude { get; set; }

	}
}