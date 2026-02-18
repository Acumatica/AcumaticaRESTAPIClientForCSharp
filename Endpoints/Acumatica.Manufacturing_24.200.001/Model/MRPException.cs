using System;
using System.Collections.Generic;

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
	public class MRPException : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_InventoryItem_descr</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Product Manager ID</para>
		/// </summary>
		public StringValue? ProductManagerID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Promise Date</para>
		/// </summary>
		public DateTimeValue? PromiseDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// </summary>
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Record ID</para>
		/// Key Field
		/// </summary>
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// Reference type
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Ref. Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? RefType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Related Document</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? RelatedDocument { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Required Date</para>
		/// </summary>
		public DateTimeValue? RequiredDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Supply Qty.</para>
		/// </summary>
		public DecimalValue? SupplyQty { get; set; }

		/// <summary>
		/// Supply Warehouse
		/// <para>DAC Field Name: SupplySiteID</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>Display Name: Supply Warehouse</para>
		/// </summary>
		public StringValue? SupplyWarehouse { get; set; }

		/// <summary>
		/// Type of MRP Exception
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// <para>SQL Type: varchar(2)</para>
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMRPExceptions</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}