using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM510000</c> in the Acumatica ERP
	/// </summary>
	public class CreateProductionOrder : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? CreationOrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public DateTimeValue? CreationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MyOwner</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public BooleanValue? Me { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkGroupID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MyWorkGroup</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public BooleanValue? My { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassCD</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? ItemClassID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public DateTimeValue? RequestedOnStartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public DateTimeValue? RequestedOnEndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? SOOrderNbr { get; set; }

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

		#endregion

		#region Details
		public List<CreateProductionDocuments>? Documents { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Documents = "Documents";

			//Intentionally excluded
			//public const string All = "Files,Translations,Documents";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}