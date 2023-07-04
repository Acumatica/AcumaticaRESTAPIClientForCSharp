using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class TemplateItems : Entity, ITopLevelEntity
	{

		[DataMember(Name="SalesUOM", EmitDefaultValue=false)]
		public StringValue SalesUOM { get; set; }

		[DataMember(Name="CurySpecificMSRP", EmitDefaultValue=false)]
		public DecimalValue CurySpecificMSRP { get; set; }

		[DataMember(Name="CurySpecificPrice", EmitDefaultValue=false)]
		public DecimalValue CurySpecificPrice { get; set; }

		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue ItemClass { get; set; }

		[DataMember(Name="Availability", EmitDefaultValue=false)]
		public StringValue Availability { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue> Attributes { get; set; }

		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue BaseUOM { get; set; }

		[DataMember(Name="Categories", EmitDefaultValue=false)]
		public List<CategoryStockItem> Categories { get; set; }

		[DataMember(Name="Content", EmitDefaultValue=false)]
		public StringValue Content { get; set; }

		[DataMember(Name="CurrentStdCost", EmitDefaultValue=false)]
		public DecimalValue CurrentStdCost { get; set; }

		[DataMember(Name="CustomURL", EmitDefaultValue=false)]
		public StringValue CustomURL { get; set; }

		[DataMember(Name="DefaultIssueLocationID", EmitDefaultValue=false)]
		public StringValue DefaultIssueLocationID { get; set; }

		[DataMember(Name="DefaultPrice", EmitDefaultValue=false)]
		public DecimalValue DefaultPrice { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DimensionWeight", EmitDefaultValue=false)]
		public DecimalValue DimensionWeight { get; set; }

		[DataMember(Name="ExportToExternal", EmitDefaultValue=false)]
		public BooleanValue ExportToExternal { get; set; }

		[DataMember(Name="FileURLs", EmitDefaultValue=false)]
		public List<InventoryFileUrls> FileURLs { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="IsStockItem", EmitDefaultValue=false)]
		public BooleanValue IsStockItem { get; set; }

		[DataMember(Name="ItemStatus", EmitDefaultValue=false)]
		public StringValue ItemStatus { get; set; }

		[DataMember(Name="LastModified", EmitDefaultValue=false)]
		public DateTimeValue LastModified { get; set; }

		[DataMember(Name="Matrix", EmitDefaultValue=false)]
		public List<MatrixItems> Matrix { get; set; }

		[DataMember(Name="MetaDescription", EmitDefaultValue=false)]
		public StringValue MetaDescription { get; set; }

		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue MSRP { get; set; }

		[DataMember(Name="PageTitle", EmitDefaultValue=false)]
		public StringValue PageTitle { get; set; }

		[DataMember(Name="SearchKeywords", EmitDefaultValue=false)]
		public StringValue SearchKeywords { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="Visibility", EmitDefaultValue=false)]
		public StringValue Visibility { get; set; }

		[DataMember(Name="WeightUOM", EmitDefaultValue=false)]
		public StringValue WeightUOM { get; set; }

		[DataMember(Name="MetaKeywords", EmitDefaultValue=false)]
		public StringValue MetaKeywords { get; set; }

		[DataMember(Name="RequireShipment", EmitDefaultValue=false)]
		public BooleanValue RequireShipment { get; set; }

		[DataMember(Name="NotAvailable", EmitDefaultValue=false)]
		public StringValue NotAvailable { get; set; }

		[DataMember(Name="VendorDetails", EmitDefaultValue=false)]
		public List<TemplateItemVendorDetail> VendorDetails { get; set; }

		public string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}