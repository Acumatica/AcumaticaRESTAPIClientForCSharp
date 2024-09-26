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
	/// Corresponds to the screen AM301500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class DisassemblyEntry : Entity, ITopLevelEntity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<DisassemblyEntryAllocation>? Allocations { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<DisassemblyEntryAttribute>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BatchNbr 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Date 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Hold 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: INDocType 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="INDocType", EmitDefaultValue=false)]
		public StringValue? INDocType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: INBatNbr 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="INRefNbr", EmitDefaultValue=false)]
		public StringValue? INRefNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LineDescription", EmitDefaultValue=false)]
		public StringValue? LineDescription { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public List<DisassemblyEntryMaterial>? Material { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderType 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TranDescription", EmitDefaultValue=false)]
		public StringValue? TranDescription { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TranType 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TranType", EmitDefaultValue=false)]
		public StringValue? TranType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UOM 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
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