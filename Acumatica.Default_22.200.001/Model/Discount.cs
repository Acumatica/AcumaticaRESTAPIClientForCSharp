using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AR209500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Discount : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BreakBy 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BreakBy", EmitDefaultValue=false)]
		public StringValue? BreakBy { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="CustomerPriceClasses", EmitDefaultValue=false)]
		public List<DiscountCustomerPriceClassesDetail>? CustomerPriceClasses { get; set; }

		[DataMember(Name="Customers", EmitDefaultValue=false)]
		public List<DiscountCustomerDetail>? Customers { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DiscountBreakpoints", EmitDefaultValue=false)]
		public List<DiscountBreakpointDetail>? DiscountBreakpoints { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DiscountedFor 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DiscountBy", EmitDefaultValue=false)]
		public StringValue? DiscountBy { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DiscountID 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue? DiscountCode { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EndDate 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		[DataMember(Name="ItemPriceClasses", EmitDefaultValue=false)]
		public List<DiscountItemPriceClassesDetail>? ItemPriceClasses { get; set; }

		[DataMember(Name="Items", EmitDefaultValue=false)]
		public List<DiscountItemDetail>? Items { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsPromotion 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Promotional", EmitDefaultValue=false)]
		public BooleanValue? Promotional { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Prorate 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProrateDiscount", EmitDefaultValue=false)]
		public BooleanValue? ProrateDiscount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DiscountSequenceID 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Sequence", EmitDefaultValue=false)]
		public StringValue? Sequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShowFreeItem 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShowFreeItem", EmitDefaultValue=false)]
		public BooleanValue? ShowFreeItem { get; set; }

		[DataMember(Name="Warehouses", EmitDefaultValue=false)]
		public List<DiscountWarehouseDetail>? Warehouses { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}