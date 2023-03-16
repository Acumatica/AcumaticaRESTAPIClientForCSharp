using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmployeePaycheckEarnings : Entity
	{

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue Employee { get; set; }

		[DataMember(Name="EmployeeType", EmitDefaultValue=false)]
		public StringValue EmployeeType { get; set; }

		[DataMember(Name="Hours", EmitDefaultValue=false)]
		public DecimalValue Hours { get; set; }

		[DataMember(Name="ManualAmount", EmitDefaultValue=false)]
		public BooleanValue ManualAmount { get; set; }

		[DataMember(Name="RegularAmounttoBePaid", EmitDefaultValue=false)]
		public DecimalValue RegularAmounttoBePaid { get; set; }

	}
}