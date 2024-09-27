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
	public class LaborRate : Entity
	{

		/// <summary>
		/// DAC Field Name: AnnualSalary 
		/// DAC: PX.Objects.PM.PMLaborCostRate 
		/// Display Name: Annual Rate 
		/// </summary>
		[DataMember(Name="AnnualRate", EmitDefaultValue=false)]
		public DecimalValue? AnnualRate { get; set; }

		/// <summary>
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.PM.PMLaborCostRate 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.PMLaborCostRate 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue? EmployeeID { get; set; }

		/// <summary>
		/// DAC Field Name: EmployeeID_description 
		/// DAC: PX.Objects.PM.PMLaborCostRate 
		/// </summary>
		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		/// <summary>
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.PM.PMLaborCostRate 
		/// Display Name: External Ref. Nbr 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		/// <summary>
		/// DAC Field Name: Rate 
		/// DAC: PX.Objects.PM.PMLaborCostRate 
		/// Display Name: Cost Rate 
		/// </summary>
		[DataMember(Name="HourlyRate", EmitDefaultValue=false)]
		public DecimalValue? HourlyRate { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		/// <summary>
		/// DAC Field Name: Type 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		[DataMember(Name="LaborRateType", EmitDefaultValue=false)]
		public StringValue? LaborRateType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// DAC Field Name: RegularHours 
		/// DAC: PX.Objects.PM.PMLaborCostRate 
		/// Display Name: Regular Hours per week 
		/// </summary>
		[DataMember(Name="RegularHoursPerWeek", EmitDefaultValue=false)]
		public DecimalValue? RegularHoursPerWeek { get; set; }

		/// <summary>
		/// DAC Field Name: EmploymentType 
		/// DAC: PX.Objects.PM.PMLaborCostRate 
		/// Display Name: Type of Employment 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="TypeOfEmployment", EmitDefaultValue=false)]
		public StringValue? TypeOfEmployment { get; set; }

		/// <summary>
		/// DAC Field Name: UnionID 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		[DataMember(Name="UnionLocalID", EmitDefaultValue=false)]
		public StringValue? UnionLocalID { get; set; }

	}
}