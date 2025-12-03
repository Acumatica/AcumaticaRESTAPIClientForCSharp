using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class EmployeeSettings : Entity
	{

		/// <summary>
		/// Represents the branch of your organization where the employee works.
		/// <para>DAC Field Name: ParentBAccountID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Branch</para>
		/// </summary>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// The identifier of the calendar that records the working hours of the employee and the time zone of the employee.
		/// <para>DAC Field Name: CalendarID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="Calendar", EmitDefaultValue=false)]
		public StringValue? Calendar { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryRateTypeID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Curr. Rate Type</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue? CurrencyRateTypeID { get; set; }

		/// <summary>
		/// Identifier of the employee department that the employee belongs to.
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Department</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="DepartmentID", EmitDefaultValue=false)]
		public StringValue? DepartmentID { get; set; }

		/// <summary>
		/// The identifier of the employee class that the employee belongs to.
		/// <para>DAC Field Name: VendorClassID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Employee Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="EmployeeClass", EmitDefaultValue=false)]
		public StringValue? EmployeeClass { get; set; }

		/// <summary>
		/// The external reference number of the employee.
		/// <para>DAC Field Name: AcctReferenceNbr</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Employee Ref. No.</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		/// <remarks>
		/// It can be an additional number of the employee used in external integration.            
		/// </remarks>
		[DataMember(Name="EmployeeRefNbr", EmitDefaultValue=false)]
		public StringValue? EmployeeRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowOverrideCury</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Enable Currency Override</para>
		/// </summary>
		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableCurrencyOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowOverrideRate</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Enable Rate Override</para>
		/// </summary>
		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableRateOverride { get; set; }

		/// <summary>
		/// The identifier of the labor item for the current employee.
		/// <para>DAC Field Name: LabourItemID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Labor Item</para>
		/// </summary>
		/// <remarks>
		/// The labor item is a non-stock item (of the Labor type) associated with the employee and used as a source of expense accounts for transactions associated with projects or contracts.
		/// </remarks>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		/// <summary>
		/// The extent of validation of regular work hours for this employee.
		/// <para>DAC Field Name: HoursValidation</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Regular Hours Validation</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="RegularHoursValidation", EmitDefaultValue=false)]
		public StringValue? RegularHoursValidation { get; set; }

		/// <summary>
		/// The identifier of the employee to whom the current employee sends reports.
		/// <para>DAC Field Name: SupervisorID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Reports to</para>
		/// </summary>
		[DataMember(Name="ReportsTo", EmitDefaultValue=false)]
		public StringValue? ReportsTo { get; set; }

		/// <summary>
		/// Specifies whether the emails addressed to this employee should be routedfrom an email account to the employee's email address if the processing of incoming mail is enabledfor the email account and the Route Employee Emails check box is selectedon the Email Accounts (SM204002) form. For details, see Incoming Mail Processing.
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Route Emails</para>
		/// </summary>
		[DataMember(Name="RouteEmails", EmitDefaultValue=false)]
		public BooleanValue? RouteEmails { get; set; }

		/// <summary>
		/// The identifier of the sales person to whom the current employee matches.
		/// <para>DAC Field Name: SalesPersonID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// </summary>
		[DataMember(Name="Salesperson", EmitDefaultValue=false)]
		public StringValue? Salesperson { get; set; }

		/// <summary>
		/// Specifies whether time cards are required for this employee.
		/// <para>DAC Field Name: TimeCardRequired</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Time Card Is Required</para>
		/// </summary>
		[DataMember(Name="TimeCardIsRequired", EmitDefaultValue=false)]
		public BooleanValue? TimeCardIsRequired { get; set; }

		/// <summary>
		/// The local identifier of the union associated with the employee.
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Union Local ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="UnionLocalID", EmitDefaultValue=false)]
		public StringValue? UnionLocalID { get; set; }

	}
}