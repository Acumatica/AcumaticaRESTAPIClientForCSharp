using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class ProjectAddress : Entity
	{

		/// <summary>
		/// The first address line.
		/// <para>DAC: PX.Objects.PM.PMAddress</para>
		/// <para>Display Name: Address Line 1</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? AddressLine1 { get; set; }

		/// <summary>
		/// The name of the city or inhabited locality.
		/// <para>DAC: PX.Objects.PM.PMAddress</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? City { get; set; }

		/// <summary>
		/// The identifier of the Country record.
		/// <para>DAC Field Name: CountryId</para>
		/// <para>DAC: PX.Objects.PM.PMSiteAddress</para>
		/// <para>SQL Type: nvarchar(2)</para>
		/// </summary>
		public StringValue? Country { get; set; }

		/// <summary>
		/// The name of the state.
		/// <para>DAC: PX.Objects.PM.PMAddress</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? State { get; set; }

		/// <summary>
		/// The postal code.
		/// <para>DAC: PX.Objects.PM.PMAddress</para>
		/// <para>Display Name: Postal Code</para>
		/// <para>SQL Type: varchar(20)</para>
		/// </summary>
		public StringValue? PostalCode { get; set; }

		/// <summary>
		/// The latitude of the address.
		/// <para>DAC: PX.Objects.PM.PMSiteAddress</para>
		/// </summary>
		public DecimalValue? Latitude { get; set; }

		/// <summary>
		/// The longitude of the address.
		/// <para>DAC: PX.Objects.PM.PMSiteAddress</para>
		/// </summary>
		public DecimalValue? Longitude { get; set; }

		public StringValue? Department { get; set; }

		public StringValue? SubDepartment { get; set; }

		public StringValue? StreetName { get; set; }

		public StringValue? BuildingNumber { get; set; }

		public StringValue? BuildingName { get; set; }

		public StringValue? Floor { get; set; }

		public StringValue? UnitNumber { get; set; }

		public StringValue? PostBox { get; set; }

		public StringValue? Room { get; set; }

		public StringValue? TownLocationName { get; set; }

		public StringValue? DistrictName { get; set; }

	}
}