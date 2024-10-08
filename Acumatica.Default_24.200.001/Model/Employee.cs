using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen EP203000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Employee : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		[DataMember(Name="ContactInfo", EmitDefaultValue=false)]
		public Contact? ContactInfo { get; set; }

		[DataMember(Name="Delegates", EmitDefaultValue=false)]
		public List<EmployeeDelegate>? Delegates { get; set; }

		/// <summary>
		/// The human-readable identifier of the employee that isspecified by the user or defined by the EMPLOYEE auto-numbering sequence during thecreation of the employee. This field is a natural key, as opposedto the surrogate key BAccountID.
		/// DAC Field Name: AcctCD 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Employee ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue? EmployeeID { get; set; }

		/// <summary>
		/// The employee name, which is usually a concatenation of thefirst and last nameof the appropriate contact.
		/// DAC Field Name: AcctName 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Employee Name 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		[DataMember(Name="EmployeeSettings", EmitDefaultValue=false)]
		public EmployeeSettings? EmployeeSettings { get; set; }

		[DataMember(Name="EmploymentHistory", EmitDefaultValue=false)]
		public List<EmploymentHistoryRecord>? EmploymentHistory { get; set; }

		[DataMember(Name="FinancialSettings", EmitDefaultValue=false)]
		public EmployeeFinancialSettings? FinancialSettings { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The status of the employee.
		/// DAC Field Name: VStatus 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}