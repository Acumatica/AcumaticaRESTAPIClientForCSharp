using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class EmployeeCostRecord : Entity
	{

		[DataMember(Name="AnnualSalaryAmount", EmitDefaultValue=false)]
		public DecimalValue AnnualSalaryAmount { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue EffectiveDate { get; set; }

		[DataMember(Name="HourlyRate", EmitDefaultValue=false)]
		public DecimalValue HourlyRate { get; set; }

		[DataMember(Name="RegularHoursPerWeek", EmitDefaultValue=false)]
		public DecimalValue RegularHoursPerWeek { get; set; }

		[DataMember(Name="TypeOfEmployment", EmitDefaultValue=false)]
		public StringValue TypeOfEmployment { get; set; }

	}
}