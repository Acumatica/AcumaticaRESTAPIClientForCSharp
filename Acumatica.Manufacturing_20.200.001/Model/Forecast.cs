using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class Forecast : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="BeginDate", EmitDefaultValue=false)]
		public DateTimeValue BeginDate { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue CustomerName { get; set; }

		[DataMember(Name="Dependent", EmitDefaultValue=false)]
		public BooleanValue Dependent { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="ForecastID", EmitDefaultValue=false)]
		public StringValue ForecastID { get; set; }

		[DataMember(Name="Interval", EmitDefaultValue=false)]
		public StringValue Interval { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue Quantity { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}