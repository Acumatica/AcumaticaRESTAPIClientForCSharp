using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM510000</c> in the Acumatica ERP
	/// </summary>
	public class CreateProductionOrder : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public DateTimeValue? CreationDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? CreationOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? Customer { get; set; }

		public List<CreateProductionDocuments>? Documents { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassCD</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? ItemClassID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MyOwner</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public BooleanValue? Me { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MyWorkGroup</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public BooleanValue? My { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrderType</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? ProdOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkGroupID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public DateTimeValue? RequestedOnEndDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public DateTimeValue? RequestedOnStartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Documents = "Documents";
			public const string Documents_Files = "Documents/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Documents,Documents/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}