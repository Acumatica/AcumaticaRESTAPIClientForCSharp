using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class LaborRate : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: Type</para>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		public StringSingleSelectValue? LaborRateType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		public StringValue? EmployeeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID</para>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		public StringValue? LaborItem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		public StringValue? UnionLocalID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeID_description</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// </summary>
		public StringValue? EmployeeName { get; set; }

		/// <summary>
		/// The description of the labor cost rate.
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The type of employment for the labor cost rate.
		/// <para>DAC Field Name: EmploymentType</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Type of Employment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? TypeOfEmployment { get; set; }

		/// <summary>
		/// The number of regular hours per week for the labor cost rate.
		/// <para>DAC Field Name: RegularHours</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Regular Hours per week</para>
		/// </summary>
		public DecimalValue? RegularHoursPerWeek { get; set; }

		/// <summary>
		/// The annual salary or rate for the labor cost rate.
		/// <para>DAC Field Name: AnnualSalary</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Annual Rate</para>
		/// </summary>
		public DecimalValue? AnnualRate { get; set; }

		/// <summary>
		/// The total labor rate, which includes both the wage rate and the burden rate.
		/// <para>DAC Field Name: Rate</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Cost Rate</para>
		/// </summary>
		public DecimalValue? HourlyRate { get; set; }

		/// <summary>
		/// The identifier of the currency for the labor cost rate.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The external reference number.
		/// <para>DAC Field Name: ExtRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: External Ref. Nbr</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? ExternalRefNbr { get; set; }

		public IntValue? RecordID { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}