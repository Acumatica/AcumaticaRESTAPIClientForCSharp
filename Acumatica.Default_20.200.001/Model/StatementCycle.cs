using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class StatementCycle : Entity_v4
	{

		[DataMember(Name="AgingPeriod1EndDay", EmitDefaultValue=false)]
		public ShortValue AgingPeriod1EndDay { get; set; }

		[DataMember(Name="AgingPeriod1Message", EmitDefaultValue=false)]
		public StringValue AgingPeriod1Message { get; set; }

		[DataMember(Name="AgingPeriod2EndDay", EmitDefaultValue=false)]
		public ShortValue AgingPeriod2EndDay { get; set; }

		[DataMember(Name="AgingPeriod2Message", EmitDefaultValue=false)]
		public StringValue AgingPeriod2Message { get; set; }

		[DataMember(Name="AgingPeriod3EndDay", EmitDefaultValue=false)]
		public ShortValue AgingPeriod3EndDay { get; set; }

		[DataMember(Name="AgingPeriod3Message", EmitDefaultValue=false)]
		public StringValue AgingPeriod3Message { get; set; }

		[DataMember(Name="AgingPeriod4Message", EmitDefaultValue=false)]
		public StringValue AgingPeriod4Message { get; set; }

		[DataMember(Name="ApplyOverdueCharges", EmitDefaultValue=false)]
		public BooleanValue ApplyOverdueCharges { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="CycleID", EmitDefaultValue=false)]
		public StringValue CycleID { get; set; }

		[DataMember(Name="DayOfMonth", EmitDefaultValue=false)]
		public ShortValue DayOfMonth { get; set; }

		[DataMember(Name="DayOfMonth1", EmitDefaultValue=false)]
		public ShortValue DayOfMonth1 { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="LastStatementDate", EmitDefaultValue=false)]
		public DateTimeValue LastStatementDate { get; set; }

		[DataMember(Name="OverdueChargeID", EmitDefaultValue=false)]
		public StringValue OverdueChargeID { get; set; }

		[DataMember(Name="PrepareOn", EmitDefaultValue=false)]
		public StringValue PrepareOn { get; set; }

		[DataMember(Name="RequireOverdueChargesCalculationBeforeStatement", EmitDefaultValue=false)]
		public BooleanValue RequireOverdueChargesCalculationBeforeStatement { get; set; }

		[DataMember(Name="RequirePaymentApplicationBeforeStatementProcessing", EmitDefaultValue=false)]
		public BooleanValue RequirePaymentApplicationBeforeStatementProcessing { get; set; }

	}
}