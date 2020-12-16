using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class EmployeeSettings : Entity_v4
	{

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue BranchID { get; set; }

		[DataMember(Name="Calendar", EmitDefaultValue=false)]
		public StringValue Calendar { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue CurrencyRateTypeID { get; set; }

		[DataMember(Name="DepartmentID", EmitDefaultValue=false)]
		public StringValue DepartmentID { get; set; }

		[DataMember(Name="EmployeeClass", EmitDefaultValue=false)]
		public StringValue EmployeeClass { get; set; }

		[DataMember(Name="EmployeeRefNbr", EmitDefaultValue=false)]
		public StringValue EmployeeRefNbr { get; set; }

		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue EnableCurrencyOverride { get; set; }

		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue EnableRateOverride { get; set; }

		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue LaborItem { get; set; }

		[DataMember(Name="RegularHoursValidation", EmitDefaultValue=false)]
		public StringValue RegularHoursValidation { get; set; }

		[DataMember(Name="ReportsTo", EmitDefaultValue=false)]
		public StringValue ReportsTo { get; set; }

		[DataMember(Name="RouteEmails", EmitDefaultValue=false)]
		public BooleanValue RouteEmails { get; set; }

		[DataMember(Name="Salesperson", EmitDefaultValue=false)]
		public StringValue Salesperson { get; set; }

		[DataMember(Name="TimeCardIsRequired", EmitDefaultValue=false)]
		public BooleanValue TimeCardIsRequired { get; set; }

		[DataMember(Name="UnionLocalID", EmitDefaultValue=false)]
		public StringValue UnionLocalID { get; set; }

	}
}