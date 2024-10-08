using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class KitAssemblyNonStockComponent : Entity
	{

		/// <summary>
		/// DAC Field Name: INKitSpecNonStkDet__DfltCompQty 
		/// DAC: PX.Objects.IN.INOverheadTran 
		/// </summary>
		[DataMember(Name="ComponentQty", EmitDefaultValue=false)]
		public DecimalValue? ComponentQty { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.IN.INComponentTran 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="NonStockInventoryID", EmitDefaultValue=false)]
		public StringValue? NonStockInventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INKitRegister 
		/// Display Name: Quantity 
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INKitRegister 
		/// Display Name: Reason Code 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INComponentTran 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INKitRegister 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}