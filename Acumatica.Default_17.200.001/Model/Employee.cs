using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class Employee : Entity
	{

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue BranchID { get; set; }

		[DataMember(Name="Contact", EmitDefaultValue=false)]
		public Contact Contact { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="DateOfBirth", EmitDefaultValue=false)]
		public DateTimeValue DateOfBirth { get; set; }

		[DataMember(Name="DepartmentID", EmitDefaultValue=false)]
		public StringValue DepartmentID { get; set; }

		[DataMember(Name="EmployeeClassID", EmitDefaultValue=false)]
		public StringValue EmployeeClassID { get; set; }

		[DataMember(Name="EmployeeCost", EmitDefaultValue=false)]
		public List<EmployeeCostRecord> EmployeeCost { get; set; }

		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue EmployeeID { get; set; }

		[DataMember(Name="EmploymentHistory", EmitDefaultValue=false)]
		public List<EmploymentHistoryRecord> EmploymentHistory { get; set; }

		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue Name { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue PaymentMethod { get; set; }

		[DataMember(Name="ReportsToID", EmitDefaultValue=false)]
		public StringValue ReportsToID { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

	}
}