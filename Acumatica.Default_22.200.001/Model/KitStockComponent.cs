using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class KitStockComponent : Entity
	{

		[DataMember(Name="AllowComponentQtyVariance", EmitDefaultValue=false)]
		public BooleanValue AllowComponentQtyVariance { get; set; }

		[DataMember(Name="ComponentQty", EmitDefaultValue=false)]
		public DecimalValue ComponentQty { get; set; }

		[DataMember(Name="MaxComponentQty", EmitDefaultValue=false)]
		public DecimalValue MaxComponentQty { get; set; }

		[DataMember(Name="MinComponentQty", EmitDefaultValue=false)]
		public DecimalValue MinComponentQty { get; set; }

		[DataMember(Name="StockInventoryID", EmitDefaultValue=false)]
		public StringValue StockInventoryID { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

	}
}