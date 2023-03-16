using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ShiftDetail : Entity
	{

		[DataMember(Name="CalendarID", EmitDefaultValue=false)]
		public StringValue CalendarID { get; set; }

		[DataMember(Name="CrewSize", EmitDefaultValue=false)]
		public DecimalValue CrewSize { get; set; }

		[DataMember(Name="DiffType", EmitDefaultValue=false)]
		public StringValue DiffType { get; set; }

		[DataMember(Name="Efficiency", EmitDefaultValue=false)]
		public DecimalValue Efficiency { get; set; }

		[DataMember(Name="LaborCode", EmitDefaultValue=false)]
		public StringValue LaborCode { get; set; }

		[DataMember(Name="Machines", EmitDefaultValue=false)]
		public DecimalValue Machines { get; set; }

		[DataMember(Name="Shift", EmitDefaultValue=false)]
		public StringValue Shift { get; set; }

		[DataMember(Name="ShiftDiff", EmitDefaultValue=false)]
		public DecimalValue ShiftDiff { get; set; }

	}
}