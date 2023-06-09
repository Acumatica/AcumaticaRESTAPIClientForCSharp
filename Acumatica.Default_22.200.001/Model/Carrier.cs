using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class Carrier : Entity
	{

		[DataMember(Name="CarrierID", EmitDefaultValue=false)]
		public StringValue CarrierID { get; set; }

		[DataMember(Name="CarrierUnits", EmitDefaultValue=false)]
		public StringValue CarrierUnits { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="CustomerAccounts", EmitDefaultValue=false)]
		public List<CarrierCustomerAccount> CustomerAccounts { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="PlugInParameters", EmitDefaultValue=false)]
		public List<CarrierPluginParameter> PlugInParameters { get; set; }

		[DataMember(Name="PlugInType", EmitDefaultValue=false)]
		public StringValue PlugInType { get; set; }

		[DataMember(Name="Centimeter", EmitDefaultValue=false)]
		public StringValue Centimeter { get; set; }

		[DataMember(Name="Inch", EmitDefaultValue=false)]
		public StringValue Inch { get; set; }

		[DataMember(Name="Kilogram", EmitDefaultValue=false)]
		public StringValue Kilogram { get; set; }

		[DataMember(Name="Pound", EmitDefaultValue=false)]
		public StringValue Pound { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }

	}
}