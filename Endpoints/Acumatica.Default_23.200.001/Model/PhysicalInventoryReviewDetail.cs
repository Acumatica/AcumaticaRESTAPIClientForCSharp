using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class PhysicalInventoryReviewDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Book Quantity</para>
		/// </summary>
		[DataMember(Name="BookQty", EmitDefaultValue=false)]
		public DecimalValue? BookQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_InventoryItem_descr</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExtVarCost</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Estimated Ext. Variance Cost</para>
		/// </summary>
		[DataMember(Name="ExtendedVarianceCost", EmitDefaultValue=false)]
		public DecimalValue? ExtendedVarianceCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Lot/Serial Number</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Physical Quantity</para>
		/// </summary>
		[DataMember(Name="PhysicalQty", EmitDefaultValue=false)]
		public DecimalValue? PhysicalQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Reason Code</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TagNumber</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Tag Nbr.</para>
		/// </summary>
		[DataMember(Name="TagNbr", EmitDefaultValue=false)]
		public IntValue? TagNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarQty</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Variance Quantity</para>
		/// </summary>
		[DataMember(Name="VarianceQty", EmitDefaultValue=false)]
		public DecimalValue? VarianceQty { get; set; }

	}
}