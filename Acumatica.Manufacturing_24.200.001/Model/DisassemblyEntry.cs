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
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// Display Name: Batch Nbr 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// Display Name: IN Doc Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="INDocType", EmitDefaultValue=false)]
		public StringValue? INDocType { get; set; }

		/// <summary>
		/// DAC Field Name: INBatNbr 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// Display Name: IN Ref Nbr 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="INRefNbr", EmitDefaultValue=false)]
		public StringValue? INRefNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// Display Name: Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="LineDescription", EmitDefaultValue=false)]
		public StringValue? LineDescription { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public List<DisassemblyEntryMaterial>? Material { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// Display Name: Post Period 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// Display Name: Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// Display Name: Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="TranDescription", EmitDefaultValue=false)]
		public StringValue? TranDescription { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// Display Name: Tran. Type 
		/// SQL Type: nchar(3) 
		/// </summary>
		[DataMember(Name="TranType", EmitDefaultValue=false)]
		public StringValue? TranType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}