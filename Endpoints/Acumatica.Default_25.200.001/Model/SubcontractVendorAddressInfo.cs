using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class SubcontractVendorAddressInfo : Entity
	{

		public StringValue? AddressLine1 { get; set; }

		public StringValue? AddressLine2 { get; set; }

		public StringValue? City { get; set; }

		public StringValue? Country { get; set; }

		public BooleanValue? VendorAddressOverride { get; set; }

		public StringValue? PostalCode { get; set; }

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