using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class Discount : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="BreakBy", EmitDefaultValue=false)]
		public StringValue? BreakBy { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="CustomerPriceClasses", EmitDefaultValue=false)]
		public List<DiscountCustomerPriceClassesDetail>? CustomerPriceClasses { get; set; }

		[DataMember(Name="Customers", EmitDefaultValue=false)]
		public List<DiscountCustomerDetail>? Customers { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DiscountBreakpoints", EmitDefaultValue=false)]
		public List<DiscountBreakpointDetail>? DiscountBreakpoints { get; set; }

		[DataMember(Name="DiscountBy", EmitDefaultValue=false)]
		public StringValue? DiscountBy { get; set; }

		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue? DiscountCode { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		[DataMember(Name="ItemPriceClasses", EmitDefaultValue=false)]
		public List<DiscountItemPriceClassesDetail>? ItemPriceClasses { get; set; }

		[DataMember(Name="Items", EmitDefaultValue=false)]
		public List<DiscountItemDetail>? Items { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Promotional", EmitDefaultValue=false)]
		public BooleanValue? Promotional { get; set; }

		[DataMember(Name="ProrateDiscount", EmitDefaultValue=false)]
		public BooleanValue? ProrateDiscount { get; set; }

		[DataMember(Name="Sequence", EmitDefaultValue=false)]
		public StringValue? Sequence { get; set; }

		[DataMember(Name="ShowFreeItem", EmitDefaultValue=false)]
		public BooleanValue? ShowFreeItem { get; set; }

		[DataMember(Name="Warehouses", EmitDefaultValue=false)]
		public List<DiscountWarehouseDetail>? Warehouses { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}