using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ReplenishmentParameterStockItem : Entity_v4
	{

		[DataMember(Name="DemandForecastModel", EmitDefaultValue=false)]
		public StringValue DemandForecastModel { get; set; }

		[DataMember(Name="ForecastPeriodType", EmitDefaultValue=false)]
		public StringValue ForecastPeriodType { get; set; }

		[DataMember(Name="LaunchDate", EmitDefaultValue=false)]
		public DateTimeValue LaunchDate { get; set; }

		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public DecimalValue MaxQty { get; set; }

		[DataMember(Name="MaxShelfLifeInDays", EmitDefaultValue=false)]
		public IntValue MaxShelfLifeInDays { get; set; }

		[DataMember(Name="Method", EmitDefaultValue=false)]
		public StringValue Method { get; set; }

		[DataMember(Name="PeriodsToAnalyze", EmitDefaultValue=false)]
		public IntValue PeriodsToAnalyze { get; set; }

		[DataMember(Name="ReorderPoint", EmitDefaultValue=false)]
		public DecimalValue ReorderPoint { get; set; }

		[DataMember(Name="ReplenishmentClass", EmitDefaultValue=false)]
		public StringValue ReplenishmentClass { get; set; }

		[DataMember(Name="ReplenishmentWarehouse", EmitDefaultValue=false)]
		public StringValue ReplenishmentWarehouse { get; set; }

		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue SafetyStock { get; set; }

		[DataMember(Name="Seasonality", EmitDefaultValue=false)]
		public StringValue Seasonality { get; set; }

		[DataMember(Name="ServiceLevel", EmitDefaultValue=false)]
		public DecimalValue ServiceLevel { get; set; }

		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue Source { get; set; }

		[DataMember(Name="TerminationDate", EmitDefaultValue=false)]
		public DateTimeValue TerminationDate { get; set; }

		[DataMember(Name="TransferERQ", EmitDefaultValue=false)]
		public DecimalValue TransferERQ { get; set; }

	}
}