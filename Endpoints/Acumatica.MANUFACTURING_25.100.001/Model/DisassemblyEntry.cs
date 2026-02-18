using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM301500</c> in the Acumatica ERP
	/// <para>Key Fields: BatchNbr</para>
	/// </summary>
	public class DisassemblyEntry : Entity, ITopLevelEntity
	{

		public List<DisassemblyEntryAllocation>? Allocations { get; set; }

		public List<DisassemblyEntryAttribute>? Attributes { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>Display Name: Batch Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// </summary>
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// </summary>
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>Display Name: IN Doc Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? INDocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INBatNbr</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>Display Name: IN Ref Nbr</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? INRefNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Description</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? LineDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// </summary>
		public StringValue? Location { get; set; }

		public List<DisassemblyEntryMaterial>? Material { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>Display Name: Post Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// </summary>
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? TranDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>Display Name: Tran. Type</para>
		/// <para>SQL Type: nchar(3)</para>
		/// </summary>
		public StringValue? TranType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Allocations = "Allocations";
			public const string Allocations_Files = "Allocations/Files";
			public const string Attributes = "Attributes";
			public const string Material = "Material";
			public const string Material_Files = "Material/Files";
			public const string Material_Allocations = "Material/Allocations";
			public const string Material_Allocations_Files = "Material/Allocations/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Allocations,Allocations/Files,Attributes,Material,Material/Files,Material/Allocations,Material/Allocations/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}