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
	/// Corresponds to the screen <c>AM403000</c> in the Acumatica ERP
	/// <para>Key Fields: RecordID</para>
	/// </summary>
	[DataContract]
	public class MRPException : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_InventoryItem_descr</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Product Manager ID</para>
		/// </summary>
		[DataMember(Name="ProductManagerID", EmitDefaultValue=false)]
		public StringValue? ProductManagerID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Promise Date</para>
		/// </summary>
		[DataMember(Name="PromiseDate", EmitDefaultValue=false)]
		public DateTimeValue? PromiseDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// </summary>
		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Record ID</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// Reference type
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Ref Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="RefType", EmitDefaultValue=false)]
		public StringValue? RefType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Related Document</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public StringValue? RelatedDocument { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Required Date</para>
		/// </summary>
		[DataMember(Name="RequiredDate", EmitDefaultValue=false)]
		public DateTimeValue? RequiredDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Supply Qty</para>
		/// </summary>
		[DataMember(Name="SupplyQty", EmitDefaultValue=false)]
		public DecimalValue? SupplyQty { get; set; }

		/// <summary>
		/// Supply Warehouse
		/// <para>DAC Field Name: SupplySiteID</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Supply Warehouse</para>
		/// </summary>
		[DataMember(Name="SupplyWarehouse", EmitDefaultValue=false)]
		public StringValue? SupplyWarehouse { get; set; }

		/// <summary>
		/// Type of MRP Exception
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>SQL Type: varchar(2)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}