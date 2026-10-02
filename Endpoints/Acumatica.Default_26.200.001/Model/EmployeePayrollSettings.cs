using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PR203000</c> in the Acumatica ERP
	/// <para>Key Fields: EmployeeID</para>
	/// </summary>
	public class EmployeePayrollSettings : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: AcctCD</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Employee ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? EmployeeID { get; set; }

		/// <summary>
		/// The employee name, which is usually a concatenation of thefirst and last nameof the appropriate contact.
		/// <para>DAC Field Name: AcctName</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Employee Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? EmployeeName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActiveInPayroll</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeClassID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Class ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmpType</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Employee Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? EmployeeType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmpTypeUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Default</para>
		/// </summary>
		public BooleanValue? EmployeeTypeClassDefault { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentMethodID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Payment Method</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CashAccountID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		public StringValue? CashAccount { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

		#region LinkedEntities
		public Address? AddressInfo { get; set; }

		public DeductionsAndBenefits? DeductionsAndBenefits { get; set; }

		public EmploymentDates? EmploymentDates { get; set; }

		public EmployeeGeneralInfo? GeneralInfo { get; set; }

		public EmployeeGLAccounts? GLAccounts { get; set; }

		public EmployeePaidTimeOff? PaidTimeOff { get; set; }

		public EmployeeWorkLocations? WorkLocations { get; set; }

		#endregion

		#region Details
		public List<CompensationDetail>? Compensation { get; set; }

		public List<DirectDepositDetail>? DirectDepositDetails { get; set; }

		public List<EmploymentRecord>? EmploymentRecords { get; set; }

		public List<EmployeeTaxDetail>? Taxes { get; set; }

		public List<TaxSettingDetail>? TaxSettings { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(EmployeePayrollSettings)} - \"{EmployeeID}\"";
		}

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
			public const string Translations = "Translations";
			public const string AddressInfo = "AddressInfo";
			public const string Compensation = "Compensation";
			public const string DeductionsAndBenefits = "DeductionsAndBenefits";
			public const string DirectDepositDetails = "DirectDepositDetails";
			public const string EmploymentDates = "EmploymentDates";
			public const string EmploymentRecords = "EmploymentRecords";
			public const string GeneralInfo = "GeneralInfo";
			public const string GLAccounts = "GLAccounts";
			public const string PaidTimeOff = "PaidTimeOff";
			public const string Taxes = "Taxes";
			public const string TaxSettings = "TaxSettings";
			public const string WorkLocations = "WorkLocations";

			//Intentionally excluded
			//public const string All = "Files,Translations,AddressInfo,Compensation,DeductionsAndBenefits,DirectDepositDetails,EmploymentDates,EmploymentRecords,GeneralInfo,GLAccounts,PaidTimeOff,Taxes,TaxSettings,WorkLocations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}