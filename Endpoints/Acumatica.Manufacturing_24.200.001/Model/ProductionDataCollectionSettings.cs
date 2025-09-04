using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class ProductionDataCollectionSettings : Entity
	{

		/// <summary>
		/// DAC Field Name: DefaultWarehouse 
		/// DAC: PX.Objects.AM.AMScanSetup 
		/// Display Name: Default Warehouse from User Profile 
		/// </summary>
		[DataMember(Name="DefaultWarehousefromUserProfile", EmitDefaultValue=false)]
		public BooleanValue? DefaultWarehousefromUserProfile { get; set; }

		/// <summary>
		/// DAC Field Name: RequestLocationForEachItemInMaterials 
		/// DAC: PX.Objects.AM.AMScanSetup 
		/// Display Name: Request Location for Each Item in Materials 
		/// </summary>
		[DataMember(Name="RequestLocationforEachIteminMaterials", EmitDefaultValue=false)]
		public BooleanValue? RequestLocationforEachIteminMaterials { get; set; }

		/// <summary>
		/// DAC Field Name: RequestLocationForEachItemInMove 
		/// DAC: PX.Objects.AM.AMScanSetup 
		/// Display Name: Request Location for Each Item in Move/Labor 
		/// </summary>
		[DataMember(Name="RequestLocationforEachIteminMoveLabor", EmitDefaultValue=false)]
		public BooleanValue? RequestLocationforEachIteminMoveLabor { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMScanSetup 
		/// Display Name: Use Default Order Type 
		/// </summary>
		[DataMember(Name="UseDefaultOrderType", EmitDefaultValue=false)]
		public BooleanValue? UseDefaultOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: UseDefaultQtyInMaterials 
		/// DAC: PX.Objects.AM.AMScanSetup 
		/// Display Name: Use Default Quantity in Materials 
		/// </summary>
		[DataMember(Name="UseDefaultQuantityinMaterials", EmitDefaultValue=false)]
		public BooleanValue? UseDefaultQuantityinMaterials { get; set; }

		/// <summary>
		/// DAC Field Name: UseDefaultQtyInMove 
		/// DAC: PX.Objects.AM.AMScanSetup 
		/// Display Name: Use Default Quantity in Move/Labor 
		/// </summary>
		[DataMember(Name="UseDefaultQuantityinMoveLabor", EmitDefaultValue=false)]
		public BooleanValue? UseDefaultQuantityinMoveLabor { get; set; }

		/// <summary>
		/// DAC Field Name: ExplicitLineConfirmation 
		/// DAC: PX.Objects.AM.AMScanSetup 
		/// Display Name: Use Explicit Line Confirmation 
		/// </summary>
		[DataMember(Name="UseExplicitLineConfirmation", EmitDefaultValue=false)]
		public BooleanValue? UseExplicitLineConfirmation { get; set; }

		/// <summary>
		/// DAC Field Name: UseRemainingQtyInMaterials 
		/// DAC: PX.Objects.AM.AMScanSetup 
		/// Display Name: Use Remaining Quantity in Materials 
		/// </summary>
		[DataMember(Name="UseRemainingQuantityinMaterials", EmitDefaultValue=false)]
		public BooleanValue? UseRemainingQuantityinMaterials { get; set; }

		/// <summary>
		/// DAC Field Name: UseRemainingQtyInMove 
		/// DAC: PX.Objects.AM.AMScanSetup 
		/// Display Name: Use Remaining Quantity in Move 
		/// </summary>
		[DataMember(Name="UseRemainingQuantityinMove", EmitDefaultValue=false)]
		public BooleanValue? UseRemainingQuantityinMove { get; set; }

	}
}