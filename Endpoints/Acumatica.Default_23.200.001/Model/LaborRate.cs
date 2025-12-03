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
	public class LaborRate : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AnnualSalary</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Annual Rate</para>
		/// </summary>
		[DataMember(Name="AnnualRate", EmitDefaultValue=false)]
		public DecimalValue? AnnualRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue? EmployeeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeID_description</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// </summary>
		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExtRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: External Ref. Nbr</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Rate</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Cost Rate</para>
		/// </summary>
		[DataMember(Name="HourlyRate", EmitDefaultValue=false)]
		public DecimalValue? HourlyRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID</para>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Type</para>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		[DataMember(Name="LaborRateType", EmitDefaultValue=false)]
		public StringValue? LaborRateType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RegularHours</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Regular Hours per week</para>
		/// </summary>
		[DataMember(Name="RegularHoursPerWeek", EmitDefaultValue=false)]
		public DecimalValue? RegularHoursPerWeek { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmploymentType</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Type of Employment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="TypeOfEmployment", EmitDefaultValue=false)]
		public StringValue? TypeOfEmployment { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		[DataMember(Name="UnionLocalID", EmitDefaultValue=false)]
		public StringValue? UnionLocalID { get; set; }

	}
}