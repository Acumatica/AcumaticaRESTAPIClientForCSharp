using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN307000</c> in the Acumatica ERP
	/// <para>Key Fields: ReferenceNbr, Type</para>
	/// </summary>
	[DataContract]
	public class KitAssembly : Entity, ITopLevelEntity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<KitAssemblyAllocation>? Allocations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDate</para>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranTranDesc</para>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="KitInventoryID", EmitDefaultValue=false)]
		public StringValue? KitInventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		[DataMember(Name="NonStockComponents", EmitDefaultValue=false)]
		public List<KitAssemblyNonStockComponent>? NonStockComponents { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>Display Name: Post Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>Display Name: Reason Code</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: KitRevisionID</para>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="StockComponents", EmitDefaultValue=false)]
		public List<KitAssemblyStockComponent>? StockComponents { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocType</para>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>SQL Type: char(1)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Allocations = "Allocations";
			public const string Allocations_Files = "Allocations/Files";
			public const string NonStockComponents = "NonStockComponents";
			public const string NonStockComponents_Files = "NonStockComponents/Files";
			public const string StockComponents = "StockComponents";
			public const string StockComponents_Files = "StockComponents/Files";
			public const string StockComponents_Allocations = "StockComponents/Allocations";
			public const string StockComponents_Allocations_Files = "StockComponents/Allocations/Files";

			//Intentionally excluded
			//public const string All = "Files,Allocations,Allocations/Files,NonStockComponents,NonStockComponents/Files,StockComponents,StockComponents/Files,StockComponents/Allocations,StockComponents/Allocations/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}