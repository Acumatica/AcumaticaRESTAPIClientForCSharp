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

		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		[DataMember(Name="CurrRate", EmitDefaultValue=false)]
		public DecimalValue? CurrRate { get; set; }

		[DataMember(Name="CuryViewState", EmitDefaultValue=false)]
		public BooleanValue? CuryViewState { get; set; }

		[DataMember(Name="LaborMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? LaborMarkupPct { get; set; }

		[DataMember(Name="MachineMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? MachineMarkupPct { get; set; }

		[DataMember(Name="MaterialMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? MaterialMarkupPct { get; set; }

		[DataMember(Name="OrderQty", EmitDefaultValue=false)]
		public DecimalValue? OrderQty { get; set; }

		[DataMember(Name="OverallMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? OverallMarkupPct { get; set; }

		[DataMember(Name="OverheadMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? OverheadMarkupPct { get; set; }

		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? ReciprocalRate { get; set; }

		[DataMember(Name="SubcontractMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? SubcontractMarkupPct { get; set; }

		[DataMember(Name="ToolMarkupPct", EmitDefaultValue=false)]
		public DecimalValue? ToolMarkupPct { get; set; }

		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		[DataMember(Name="TotalPrice", EmitDefaultValue=false)]
		public DecimalValue? TotalPrice { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

		[DataMember(Name="UnitPriceOverride", EmitDefaultValue=false)]
		public BooleanValue? UnitPriceOverride { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}