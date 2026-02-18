using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class SrvOrdAddress : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAddress</para>
		/// <para>Display Name: Address Line 1</para>
		/// <para>SQL Type: nvarchar(70)</para>
		/// </summary>
		public StringValue? AddressLine1 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAddress</para>
		/// <para>Display Name: Address Line 2</para>
		/// <para>SQL Type: nvarchar(70)</para>
		/// </summary>
		public StringValue? AddressLine2 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAddress</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? City { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CountryID</para>
		/// <para>DAC: PX.Objects.FS.FSAddress</para>
		/// <para>SQL Type: nvarchar(2)</para>
		/// </summary>
		public StringValue? Country { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAddress</para>
		/// <para>Display Name: Postal Code</para>
		/// <para>SQL Type: varchar(20)</para>
		/// </summary>
		public StringValue? PostalCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAddress</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? State { get; set; }

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