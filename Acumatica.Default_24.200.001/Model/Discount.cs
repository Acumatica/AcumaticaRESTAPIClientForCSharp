using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AR209500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Discount : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// Display Name: Break By 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="BreakBy", EmitDefaultValue=false)]
		public StringValue? BreakBy { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="CustomerPriceClasses", EmitDefaultValue=false)]
		public List<DiscountCustomerPriceClassesDetail>? CustomerPriceClasses { get; set; }

		[DataMember(Name="Customers", EmitDefaultValue=false)]
		public List<DiscountCustomerDetail>? Customers { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// SQL Type: nvarchar(250) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DiscountBreakpoints", EmitDefaultValue=false)]
		public List<DiscountBreakpointDetail>? DiscountBreakpoints { get; set; }

		/// <summary>
		/// DAC Field Name: DiscountedFor 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// Display Name: Discount By 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="DiscountBy", EmitDefaultValue=false)]
		public StringValue? DiscountBy { get; set; }

		/// <summary>
		/// DAC Field Name: DiscountID 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// Display Name: Discount Code 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue? DiscountCode { get; set; }

		/// <summary>
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// Display Name: Effective Date 
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// DAC Field Name: EndDate 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// Display Name: Expiration Date 
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		[DataMember(Name="ItemPriceClasses", EmitDefaultValue=false)]
		public List<DiscountItemPriceClassesDetail>? ItemPriceClasses { get; set; }

		[DataMember(Name="Items", EmitDefaultValue=false)]
		public List<DiscountItemDetail>? Items { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: IsPromotion 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// </summary>
		[DataMember(Name="Promotional", EmitDefaultValue=false)]
		public BooleanValue? Promotional { get; set; }

		/// <summary>
		/// DAC Field Name: Prorate 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// Display Name: Prorate Discount 
		/// </summary>
		[DataMember(Name="ProrateDiscount", EmitDefaultValue=false)]
		public BooleanValue? ProrateDiscount { get; set; }

		/// <summary>
		/// DAC Field Name: DiscountSequenceID 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Sequence", EmitDefaultValue=false)]
		public StringValue? Sequence { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// </summary>
		[DataMember(Name="ShowFreeItem", EmitDefaultValue=false)]
		public BooleanValue? ShowFreeItem { get; set; }

		[DataMember(Name="Warehouses", EmitDefaultValue=false)]
		public List<DiscountWarehouseDetail>? Warehouses { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}