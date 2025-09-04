using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM403000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class MRPException : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryID_InventoryItem_descr 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// Display Name: Item Class 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// Display Name: Product Manager ID 
		/// </summary>
		[DataMember(Name="ProductManagerID", EmitDefaultValue=false)]
		public StringValue? ProductManagerID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// Display Name: Promise Date 
		/// </summary>
		[DataMember(Name="PromiseDate", EmitDefaultValue=false)]
		public DateTimeValue? PromiseDate { get; set; }

		/// <summary>
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// Display Name: Record ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// Reference type
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// Display Name: Ref Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="RefType", EmitDefaultValue=false)]
		public StringValue? RefType { get; set; }

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// Display Name: Related Document 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public StringValue? RelatedDocument { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// Display Name: Required Date 
		/// </summary>
		[DataMember(Name="RequiredDate", EmitDefaultValue=false)]
		public DateTimeValue? RequiredDate { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// Display Name: Supply Qty 
		/// </summary>
		[DataMember(Name="SupplyQty", EmitDefaultValue=false)]
		public DecimalValue? SupplyQty { get; set; }

		/// <summary>
		/// Supply Warehouse
		/// DAC Field Name: SupplySiteID 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// Display Name: Supply Warehouse 
		/// </summary>
		[DataMember(Name="SupplyWarehouse", EmitDefaultValue=false)]
		public StringValue? SupplyWarehouse { get; set; }

		/// <summary>
		/// Type of MRP Exception
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// SQL Type: varchar(2) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMRPExceptions 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}