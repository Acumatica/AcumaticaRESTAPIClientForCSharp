using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class SalesPriceDetail : Entity
	{

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue NoteID { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

		[DataMember(Name="TaxCalculationMode", EmitDefaultValue=false)]
		public StringValue TaxCalculationMode { get; set; }

		[DataMember(Name="BreakQty", EmitDefaultValue=false)]
		public DecimalValue BreakQty { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue EffectiveDate { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue ExpirationDate { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="Price", EmitDefaultValue=false)]
		public DecimalValue Price { get; set; }

		[DataMember(Name="PriceCode", EmitDefaultValue=false)]
		public StringValue PriceCode { get; set; }

		[DataMember(Name="PriceType", EmitDefaultValue=false)]
		public StringValue PriceType { get; set; }

		[DataMember(Name="Promotion", EmitDefaultValue=false)]
		public BooleanValue Promotion { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue RecordID { get; set; }

		[DataMember(Name="Tax", EmitDefaultValue=false)]
		public StringValue Tax { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

	}
}