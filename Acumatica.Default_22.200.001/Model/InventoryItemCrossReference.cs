using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class InventoryItemCrossReference : Entity
	{

		[DataMember(Name="AlternateID", EmitDefaultValue=false)]
		public StringValue? AlternateID { get; set; }

		[DataMember(Name="AlternateType", EmitDefaultValue=false)]
		public StringValue? AlternateType { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		[DataMember(Name="VendorOrCustomer", EmitDefaultValue=false)]
		public StringValue? VendorOrCustomer { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}