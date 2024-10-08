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
	public class EstimateTotal : Entity
	{

		/// <summary>
		/// Identifier of the base Currency.
		/// DAC Field Name: BaseCuryID 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Base Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		/// <summary>
		/// The read-only property providing the Currency for display in the User Interface.
		/// DAC Field Name: DisplayCuryID 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The exchange rate used for calculations and determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// DAC Field Name: SampleCuryRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Curr. Rate 
		/// </summary>
		[DataMember(Name="CurrRate", EmitDefaultValue=false)]
		public DecimalValue? CurrRate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		[DataMember(Name="CuryViewState", EmitDefaultValue=false)]
		public BooleanValue? CuryViewState { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Labor Markup (%) 
		/// </summary>
		[DataMember(Name="LaborMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? LaborMarkupPct { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Machine Markup (%) 
		/// </summary>
		[DataMember(Name="MachineMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? MachineMarkupPct { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Material Markup (%) 
		/// </summary>
		[DataMember(Name="MaterialMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? MaterialMarkupPct { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Order Qty. 
		/// </summary>
		[DataMember(Name="OrderQty", EmitDefaultValue=false)]
		public DecimalValue? OrderQty { get; set; }

		/// <summary>
		/// DAC Field Name: MarkupPct 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Overall Markup (%) 
		/// </summary>
		[DataMember(Name="OverallMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? OverallMarkupPct { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Overhead Markup (%) 
		/// </summary>
		[DataMember(Name="OverheadMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? OverheadMarkupPct { get; set; }

		/// <summary>
		/// The inverse of the SampleCuryRate. This value is also determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// DAC Field Name: SampleRecipRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Reciprocal Rate 
		/// </summary>
		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? ReciprocalRate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Subcontract Markup (%) 
		/// </summary>
		[DataMember(Name="SubcontractMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? SubcontractMarkupPct { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Tool Markup (%) 
		/// </summary>
		[DataMember(Name="ToolMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? ToolMarkupPct { get; set; }

		/// <summary>
		/// DAC Field Name: CuryExtCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Total Cost 
		/// </summary>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// DAC Field Name: CuryExtPrice 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Total Price 
		/// </summary>
		[DataMember(Name="TotalPrice", EmitDefaultValue=false)]
		public DecimalValue? TotalPrice { get; set; }

		/// <summary>
		/// DAC Field Name: CuryUnitCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// DAC Field Name: CuryUnitPrice 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Unit Price 
		/// </summary>
		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

		/// <summary>
		/// DAC Field Name: PriceOverride 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Unit Price 
		/// </summary>
		[DataMember(Name="UnitPriceOverride", EmitDefaultValue=false)]
		public BooleanValue? UnitPriceOverride { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}