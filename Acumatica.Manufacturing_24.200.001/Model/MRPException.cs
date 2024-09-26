using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM403000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class MRPException : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID_InventoryItem_descr 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductManagerID 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductManagerID", EmitDefaultValue=false)]
		public StringValue? ProductManagerID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PromiseDate 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PromiseDate", EmitDefaultValue=false)]
		public DateTimeValue? PromiseDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RecordID 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefType 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RefType", EmitDefaultValue=false)]
		public StringValue? RefType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public StringValue? RelatedDocument { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RequiredDate 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequiredDate", EmitDefaultValue=false)]
		public DateTimeValue? RequiredDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SupplyQty 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SupplyQty", EmitDefaultValue=false)]
		public DecimalValue? SupplyQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SupplySiteID 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SupplyWarehouse", EmitDefaultValue=false)]
		public StringValue? SupplyWarehouse { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Type 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}