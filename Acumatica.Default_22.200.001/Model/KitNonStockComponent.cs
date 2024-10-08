using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class KitNonStockComponent : Entity
	{

		/// <summary>
		/// DAC Field Name: AllowQtyVariation 
		/// DAC: PX.Objects.IN.INKitSpecStkDet 
		/// Display Name: Allow Component Qty. Variance 
		/// </summary>
		[DataMember(Name="AllowComponentQtyVariance", EmitDefaultValue=false)]
		public BooleanValue? AllowComponentQtyVariance { get; set; }

		/// <summary>
		/// DAC Field Name: DfltCompQty 
		/// DAC: PX.Objects.IN.INKitSpecStkDet 
		/// Display Name: Component Qty. 
		/// </summary>
		[DataMember(Name="ComponentQty", EmitDefaultValue=false)]
		public DecimalValue? ComponentQty { get; set; }

		/// <summary>
		/// DAC Field Name: MaxCompQty 
		/// DAC: PX.Objects.IN.INKitSpecStkDet 
		/// Display Name: Max. Component Qty. 
		/// </summary>
		[DataMember(Name="MaxComponentQty", EmitDefaultValue=false)]
		public DecimalValue? MaxComponentQty { get; set; }

		/// <summary>
		/// DAC Field Name: MinCompQty 
		/// DAC: PX.Objects.IN.INKitSpecStkDet 
		/// Display Name: Min. Component Qty. 
		/// </summary>
		[DataMember(Name="MinComponentQty", EmitDefaultValue=false)]
		public DecimalValue? MinComponentQty { get; set; }

		/// <summary>
		/// DAC Field Name: CompInventoryID 
		/// DAC: PX.Objects.IN.INKitSpecStkDet 
		/// Display Name: Component ID 
		/// </summary>
		[DataMember(Name="NonStockInventoryID", EmitDefaultValue=false)]
		public StringValue? NonStockInventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INKitSpecStkDet 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}