using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AR202800 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class StatementCycle : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AgeDays00 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AgingPeriod1EndDay", EmitDefaultValue=false)]
		public ShortValue? AgingPeriod1EndDay { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AgeMsg00 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AgingPeriod1Message", EmitDefaultValue=false)]
		public StringValue? AgingPeriod1Message { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AgeDays01 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AgingPeriod2EndDay", EmitDefaultValue=false)]
		public ShortValue? AgingPeriod2EndDay { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AgeMsg01 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AgingPeriod2Message", EmitDefaultValue=false)]
		public StringValue? AgingPeriod2Message { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AgeDays02 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AgingPeriod3EndDay", EmitDefaultValue=false)]
		public ShortValue? AgingPeriod3EndDay { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AgeMsg02 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AgingPeriod3Message", EmitDefaultValue=false)]
		public StringValue? AgingPeriod3Message { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AgeMsg03 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AgingPeriod4Message", EmitDefaultValue=false)]
		public StringValue? AgingPeriod4Message { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinChargeApply 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ApplyOverdueCharges", EmitDefaultValue=false)]
		public BooleanValue? ApplyOverdueCharges { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StatementCycleId 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CycleID", EmitDefaultValue=false)]
		public StringValue? CycleID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Day00 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DayOfMonth", EmitDefaultValue=false)]
		public ShortValue? DayOfMonth { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Day01 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DayOfMonth1", EmitDefaultValue=false)]
		public ShortValue? DayOfMonth1 { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastStmtDate 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastStatementDate", EmitDefaultValue=false)]
		public DateTimeValue? LastStatementDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinChargeID 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverdueChargeID", EmitDefaultValue=false)]
		public StringValue? OverdueChargeID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PrepareOn 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PrepareOn", EmitDefaultValue=false)]
		public StringValue? PrepareOn { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RequireFinChargeProcessing 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequireOverdueChargesCalculationBeforeStatement", EmitDefaultValue=false)]
		public BooleanValue? RequireOverdueChargesCalculationBeforeStatement { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RequirePaymentApplication 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequirePaymentApplicationBeforeStatementProcessing", EmitDefaultValue=false)]
		public BooleanValue? RequirePaymentApplicationBeforeStatementProcessing { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}