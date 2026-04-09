using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class ProjectAddress : Entity
	{

		[DataMember(Name="AddressLine1", EmitDefaultValue=false)]
		public StringValue? AddressLine1 { get; set; }

		[DataMember(Name="City", EmitDefaultValue=false)]
		public StringValue? City { get; set; }

		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

		[DataMember(Name="PostalCode", EmitDefaultValue=false)]
		public StringValue? PostalCode { get; set; }

		[DataMember(Name="Latitude", EmitDefaultValue=false)]
		public DecimalValue? Latitude { get; set; }

		[DataMember(Name="Longitude", EmitDefaultValue=false)]
		public DecimalValue? Longitude { get; set; }

		[DataMember(Name="Department", EmitDefaultValue=false)]
		public StringValue? Department { get; set; }

		[DataMember(Name="SubDepartment", EmitDefaultValue=false)]
		public StringValue? SubDepartment { get; set; }

		[DataMember(Name="StreetName", EmitDefaultValue=false)]
		public StringValue? StreetName { get; set; }

		[DataMember(Name="BuildingNumber", EmitDefaultValue=false)]
		public StringValue? BuildingNumber { get; set; }

		[DataMember(Name="BuildingName", EmitDefaultValue=false)]
		public StringValue? BuildingName { get; set; }

		[DataMember(Name="Floor", EmitDefaultValue=false)]
		public StringValue? Floor { get; set; }

		[DataMember(Name="UnitNumber", EmitDefaultValue=false)]
		public StringValue? UnitNumber { get; set; }

		[DataMember(Name="PostBox", EmitDefaultValue=false)]
		public StringValue? PostBox { get; set; }

		[DataMember(Name="Room", EmitDefaultValue=false)]
		public StringValue? Room { get; set; }

		[DataMember(Name="TownLocationName", EmitDefaultValue=false)]
		public StringValue? TownLocationName { get; set; }

		[DataMember(Name="DistrictName", EmitDefaultValue=false)]
		public StringValue? DistrictName { get; set; }

	}
}