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
	public class PhysicalInventoryCountDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.IN.INPIDetail 
		/// Display Name: Book Quantity 
		/// </summary>
		[DataMember(Name="BookQty", EmitDefaultValue=false)]
		public DecimalValue? BookQty { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryID_InventoryItem_descr 
		/// DAC: PX.Objects.IN.INPIDetail 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.PICountFilter 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INPIDetail 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.IN.PICountFilter 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.PICountFilter 
		/// Display Name: Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INPIDetail 
		/// Display Name: Physical Quantity 
		/// </summary>
		[DataMember(Name="PhysicalQty", EmitDefaultValue=false)]
		public DecimalValue? PhysicalQty { get; set; }

		/// <summary>
		/// DAC Field Name: PIID 
		/// DAC: PX.Objects.IN.INPIHeader 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.IN.INBarCodeItem 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

	}
}