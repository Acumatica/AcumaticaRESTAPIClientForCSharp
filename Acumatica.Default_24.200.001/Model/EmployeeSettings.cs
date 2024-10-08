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
		/// DAC Field Name: ParentBAccountID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Branch 
		/// </summary>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// The identifier of the calendar that records the working hours of the employee and the time zone of the employee.
		/// DAC Field Name: CalendarID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Calendar", EmitDefaultValue=false)]
		public StringValue? Calendar { get; set; }

		/// <summary>
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: CuryRateTypeID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Curr. Rate Type 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue? CurrencyRateTypeID { get; set; }

		/// <summary>
		/// Identifier of the employee department that the employee belongs to.
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Department 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="DepartmentID", EmitDefaultValue=false)]
		public StringValue? DepartmentID { get; set; }

		/// <summary>
		/// The identifier of the employee class that the employee belongs to.
		/// DAC Field Name: VendorClassID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Employee Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="EmployeeClass", EmitDefaultValue=false)]
		public StringValue? EmployeeClass { get; set; }

		/// <summary>
		/// The external reference number of the employee.
		/// DAC Field Name: AcctReferenceNbr 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Employee Ref. No. 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		/// <remarks>
		/// It can be an additional number of the employee used in external integration.            
		/// </remarks>
		[DataMember(Name="EmployeeRefNbr", EmitDefaultValue=false)]
		public StringValue? EmployeeRefNbr { get; set; }

		/// <summary>
		/// DAC Field Name: AllowOverrideCury 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Enable Currency Override 
		/// </summary>
		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableCurrencyOverride { get; set; }

		/// <summary>
		/// DAC Field Name: AllowOverrideRate 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Enable Rate Override 
		/// </summary>
		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableRateOverride { get; set; }

		/// <summary>
		/// The identifier of the labor item for the current employee.
		/// DAC Field Name: LabourItemID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Labor Item 
		/// </summary>
		/// <remarks>
		/// The labor item is a non-stock item (of the Labor type) associated with the employee and used as a source of expense accounts for transactions associated with projects or contracts.
		/// </remarks>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		/// <summary>
		/// The extent of validation of regular work hours for this employee.
		/// DAC Field Name: HoursValidation 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Regular Hours Validation 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="RegularHoursValidation", EmitDefaultValue=false)]
		public StringValue? RegularHoursValidation { get; set; }

		/// <summary>
		/// The identifier of the employee to whom the current employee sends reports.
		/// DAC Field Name: SupervisorID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Reports to 
		/// </summary>
		[DataMember(Name="ReportsTo", EmitDefaultValue=false)]
		public StringValue? ReportsTo { get; set; }

		/// <summary>
		/// Specifies whether the emails addressed to this employee should be routedfrom an email account to the employee's email address if the processing of incoming mail is enabledfor the email account and the Route Employee Emails check box is selectedon the Email Accounts (SM204002) form. For details, see Incoming Mail Processing.
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Route Emails 
		/// </summary>
		[DataMember(Name="RouteEmails", EmitDefaultValue=false)]
		public BooleanValue? RouteEmails { get; set; }

		/// <summary>
		/// The identifier of the sales person to whom the current employee matches.
		/// DAC Field Name: SalesPersonID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// </summary>
		[DataMember(Name="Salesperson", EmitDefaultValue=false)]
		public StringValue? Salesperson { get; set; }

		/// <summary>
		/// Specifies whether time cards are required for this employee.
		/// DAC Field Name: TimeCardRequired 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Time Card Is Required 
		/// </summary>
		[DataMember(Name="TimeCardIsRequired", EmitDefaultValue=false)]
		public BooleanValue? TimeCardIsRequired { get; set; }

		/// <summary>
		/// The local identifier of the union associated with the employee.
		/// DAC Field Name: UnionID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Union Local ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="UnionLocalID", EmitDefaultValue=false)]
		public StringValue? UnionLocalID { get; set; }

	}
}