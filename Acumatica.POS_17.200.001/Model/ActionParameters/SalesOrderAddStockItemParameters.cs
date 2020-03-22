using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class SalesOrderAddStockItemParameters
	{
		public SalesOrderAddStockItemParameters() { }

		[DataMember(Name="BarCode", EmitDefaultValue=false)]
		public StringValue BarCode { get; set; }
		[DataMember(Name="Inventory", EmitDefaultValue=false)]
		public StringValue Inventory { get; set; }
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}