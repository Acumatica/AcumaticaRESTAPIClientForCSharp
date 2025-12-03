using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PR203000</c> in the Acumatica ERP
	/// <para>Key Fields: EmployeeID</para>
	/// </summary>
	[DataContract]
	public class EmployeePayrollSettings : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: ActiveInPayroll</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AddressInfo", EmitDefaultValue=false)]
		public Address? AddressInfo { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CashAccountID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeClassID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Class ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		[DataMember(Name="Compensation", EmitDefaultValue=false)]
		public List<CompensationDetail>? Compensation { get; set; }

		[DataMember(Name="DeductionsAndBenefits", EmitDefaultValue=false)]
		public DeductionsAndBenefits? DeductionsAndBenefits { get; set; }

		[DataMember(Name="DirectDepositDetails", EmitDefaultValue=false)]
		public List<DirectDepositDetail>? DirectDepositDetails { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AcctCD</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Employee ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue? EmployeeID { get; set; }

		/// <summary>
		/// The employee name, which is usually a concatenation of thefirst and last nameof the appropriate contact.
		/// <para>DAC Field Name: AcctName</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Employee Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmpType</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Employee Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="EmployeeType", EmitDefaultValue=false)]
		public StringValue? EmployeeType { get; set; }

		[DataMember(Name="EmploymentDates", EmitDefaultValue=false)]
		public EmploymentDates? EmploymentDates { get; set; }

		[DataMember(Name="EmploymentRecords", EmitDefaultValue=false)]
		public List<EmploymentRecord>? EmploymentRecords { get; set; }

		[DataMember(Name="GeneralInfo", EmitDefaultValue=false)]
		public EmployeeGeneralInfo? GeneralInfo { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public EmployeeGLAccounts? GLAccounts { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="PaidTimeOff", EmitDefaultValue=false)]
		public EmployeePaidTimeOff? PaidTimeOff { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentMethodID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Payment Method</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		[DataMember(Name="Taxes", EmitDefaultValue=false)]
		public List<EmployeeTaxDetail>? Taxes { get; set; }

		[DataMember(Name="TaxSettings", EmitDefaultValue=false)]
		public List<TaxSettingDetail>? TaxSettings { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmpTypeUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Default</para>
		/// </summary>
		[DataMember(Name="EmployeeTypeClassDefault", EmitDefaultValue=false)]
		public BooleanValue? EmployeeTypeClassDefault { get; set; }

		[DataMember(Name="WorkLocations", EmitDefaultValue=false)]
		public EmployeeWorkLocations? WorkLocations { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string AddressInfo = "AddressInfo";
			public const string Compensation = "Compensation";
			public const string Compensation_Files = "Compensation/Files";
			public const string DeductionsAndBenefits = "DeductionsAndBenefits";
			public const string DeductionsAndBenefits_DeductionsAndBenefitsDetails = "DeductionsAndBenefits/DeductionsAndBenefitsDetails";
			public const string DeductionsAndBenefits_DeductionsAndBenefitsDetails_Files = "DeductionsAndBenefits/DeductionsAndBenefitsDetails/Files";
			public const string DeductionsAndBenefits_DeductionsAndBenefitsDetails_GarnishmentDetails = "DeductionsAndBenefits/DeductionsAndBenefitsDetails/GarnishmentDetails";
			public const string DirectDepositDetails = "DirectDepositDetails";
			public const string DirectDepositDetails_Files = "DirectDepositDetails/Files";
			public const string EmploymentDates = "EmploymentDates";
			public const string EmploymentRecords = "EmploymentRecords";
			public const string EmploymentRecords_Files = "EmploymentRecords/Files";
			public const string GeneralInfo = "GeneralInfo";
			public const string GLAccounts = "GLAccounts";
			public const string PaidTimeOff = "PaidTimeOff";
			public const string PaidTimeOff_PaidTimeOffDetails = "PaidTimeOff/PaidTimeOffDetails";
			public const string PaidTimeOff_PaidTimeOffDetails_Files = "PaidTimeOff/PaidTimeOffDetails/Files";
			public const string Taxes = "Taxes";
			public const string Taxes_Files = "Taxes/Files";
			public const string Taxes_TaxCodeSettings = "Taxes/TaxCodeSettings";
			public const string Taxes_TaxCodeSettings_Files = "Taxes/TaxCodeSettings/Files";
			public const string TaxSettings = "TaxSettings";
			public const string TaxSettings_Files = "TaxSettings/Files";
			public const string WorkLocations = "WorkLocations";
			public const string WorkLocations_WorkLocationDetails = "WorkLocations/WorkLocationDetails";
			public const string WorkLocations_WorkLocationDetails_Files = "WorkLocations/WorkLocationDetails/Files";

			//Intentionally excluded
			//public const string All = "Files,AddressInfo,Compensation,Compensation/Files,DeductionsAndBenefits,DeductionsAndBenefits/DeductionsAndBenefitsDetails,DeductionsAndBenefits/DeductionsAndBenefitsDetails/Files,DeductionsAndBenefits/DeductionsAndBenefitsDetails/GarnishmentDetails,DirectDepositDetails,DirectDepositDetails/Files,EmploymentDates,EmploymentRecords,EmploymentRecords/Files,GeneralInfo,GLAccounts,PaidTimeOff,PaidTimeOff/PaidTimeOffDetails,PaidTimeOff/PaidTimeOffDetails/Files,Taxes,Taxes/Files,Taxes/TaxCodeSettings,Taxes/TaxCodeSettings/Files,TaxSettings,TaxSettings/Files,WorkLocations,WorkLocations/WorkLocationDetails,WorkLocations/WorkLocationDetails/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}