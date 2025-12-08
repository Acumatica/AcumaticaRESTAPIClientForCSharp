using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	[DataContract]
	public class ProductionDataCollectionSettings : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: DefaultWarehouse</para>
		/// <para>DAC: PX.Objects.AM.AMScanSetup</para>
		/// <para>Display Name: Default Warehouse from User Profile</para>
		/// </summary>
		[DataMember(Name="DefaultWarehousefromUserProfile", EmitDefaultValue=false)]
		public BooleanValue? DefaultWarehousefromUserProfile { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RequestLocationForEachItemInMaterials</para>
		/// <para>DAC: PX.Objects.AM.AMScanSetup</para>
		/// <para>Display Name: Request Location for Each Item in Materials</para>
		/// </summary>
		[DataMember(Name="RequestLocationforEachIteminMaterials", EmitDefaultValue=false)]
		public BooleanValue? RequestLocationforEachIteminMaterials { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RequestLocationForEachItemInMove</para>
		/// <para>DAC: PX.Objects.AM.AMScanSetup</para>
		/// <para>Display Name: Request Location for Each Item in Move/Labor</para>
		/// </summary>
		[DataMember(Name="RequestLocationforEachIteminMoveLabor", EmitDefaultValue=false)]
		public BooleanValue? RequestLocationforEachIteminMoveLabor { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMScanSetup</para>
		/// <para>Display Name: Use Default Order Type</para>
		/// </summary>
		[DataMember(Name="UseDefaultOrderType", EmitDefaultValue=false)]
		public BooleanValue? UseDefaultOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseDefaultQtyInMaterials</para>
		/// <para>DAC: PX.Objects.AM.AMScanSetup</para>
		/// <para>Display Name: Use Default Quantity in Materials</para>
		/// </summary>
		[DataMember(Name="UseDefaultQuantityinMaterials", EmitDefaultValue=false)]
		public BooleanValue? UseDefaultQuantityinMaterials { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseDefaultQtyInMove</para>
		/// <para>DAC: PX.Objects.AM.AMScanSetup</para>
		/// <para>Display Name: Use Default Quantity in Move/Labor</para>
		/// </summary>
		[DataMember(Name="UseDefaultQuantityinMoveLabor", EmitDefaultValue=false)]
		public BooleanValue? UseDefaultQuantityinMoveLabor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExplicitLineConfirmation</para>
		/// <para>DAC: PX.Objects.AM.AMScanSetup</para>
		/// <para>Display Name: Use Explicit Line Confirmation</para>
		/// </summary>
		[DataMember(Name="UseExplicitLineConfirmation", EmitDefaultValue=false)]
		public BooleanValue? UseExplicitLineConfirmation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseRemainingQtyInMaterials</para>
		/// <para>DAC: PX.Objects.AM.AMScanSetup</para>
		/// <para>Display Name: Use Remaining Quantity in Materials</para>
		/// </summary>
		[DataMember(Name="UseRemainingQuantityinMaterials", EmitDefaultValue=false)]
		public BooleanValue? UseRemainingQuantityinMaterials { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseRemainingQtyInMove</para>
		/// <para>DAC: PX.Objects.AM.AMScanSetup</para>
		/// <para>Display Name: Use Remaining Quantity in Move</para>
		/// </summary>
		[DataMember(Name="UseRemainingQuantityinMove", EmitDefaultValue=false)]
		public BooleanValue? UseRemainingQuantityinMove { get; set; }

	}
}