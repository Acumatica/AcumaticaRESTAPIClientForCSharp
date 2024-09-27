using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class MRPDetailInquiryResult : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPPlan 
		/// Display Name: Parent Inventory ID 
		/// </summary>
		[DataMember(Name="ParentInventoryID", EmitDefaultValue=false)]
		public StringValue? ParentInventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ParentSubItemID 
		/// DAC: PX.Objects.AM.AMRPPlan 
		/// Display Name: Parent Subitem 
		/// </summary>
		[DataMember(Name="ParentSubitem", EmitDefaultValue=false)]
		public StringValue? ParentSubitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPPlan 
		/// Display Name: Product Inventory ID 
		/// </summary>
		[DataMember(Name="ProductInventoryID", EmitDefaultValue=false)]
		public StringValue? ProductInventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ProductSubItemID 
		/// DAC: PX.Objects.AM.AMRPPlan 
		/// Display Name: Product Subitem 
		/// </summary>
		[DataMember(Name="ProductSubitem", EmitDefaultValue=false)]
		public StringValue? ProductSubitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPPlan 
		/// Display Name: Promise Date 
		/// </summary>
		[DataMember(Name="PromiseDate", EmitDefaultValue=false)]
		public DateTimeValue? PromiseDate { get; set; }

		/// <summary>
		/// DAC Field Name: BaseQty 
		/// DAC: PX.Objects.AM.AMRPPlan 
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// Qty on hand
		/// DAC: PX.Objects.AM.InvLookup 
		/// Display Name: Qty On Hand 
		/// </summary>
		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHand { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// Plan type related to the RefOrdertype and RefOrderNbr
		/// DAC Field Name: RefType 
		/// DAC: PX.Objects.AM.AMRPPlan 
		/// Display Name: Reference Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="ReferenceType", EmitDefaultValue=false)]
		public StringValue? ReferenceType { get; set; }

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AM.AMRPPlan 
		/// Display Name: Related Document 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public StringValue? RelatedDocument { get; set; }

		/// <summary>
		/// Planning Type
		/// DAC: PX.Objects.AM.AMRPPlan 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}