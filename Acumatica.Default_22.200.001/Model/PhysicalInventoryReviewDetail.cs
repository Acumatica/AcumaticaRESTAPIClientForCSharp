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
	public class PhysicalInventoryReviewDetail : Entity
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
		/// DAC Field Name: ExpireDate 
		/// DAC: PX.Objects.IN.INPIDetail 
		/// Display Name: Expiration Date 
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// DAC Field Name: ExtVarCost 
		/// DAC: PX.Objects.IN.INPIDetail 
		/// Display Name: Estimated Ext. Variance Cost 
		/// </summary>
		[DataMember(Name="ExtendedVarianceCost", EmitDefaultValue=false)]
		public DecimalValue? ExtendedVarianceCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INPIDetail 
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
		/// DAC: PX.Objects.IN.INPIDetail 
		/// Display Name: Location 
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INPIDetail 
		/// Display Name: Lot/Serial Number 
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
		/// DAC: PX.Objects.IN.INPIDetail 
		/// Display Name: Reason Code 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INPIHeader 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.IN.INPIDetail 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: TagNumber 
		/// DAC: PX.Objects.IN.INPIDetail 
		/// Display Name: Tag Nbr. 
		/// </summary>
		[DataMember(Name="TagNbr", EmitDefaultValue=false)]
		public IntValue? TagNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INPIDetail 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// DAC Field Name: VarQty 
		/// DAC: PX.Objects.IN.INPIDetail 
		/// Display Name: Variance Quantity 
		/// </summary>
		[DataMember(Name="VarianceQty", EmitDefaultValue=false)]
		public DecimalValue? VarianceQty { get; set; }

	}
}