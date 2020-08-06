using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SalesOrderCreateShipmentParameters
	{
		public SalesOrderCreateShipmentParameters() { }

		[DataMember(Name="ShipmentDate", EmitDefaultValue=false)]
		public DateTimeValue ShipmentDate { get; set; }
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}