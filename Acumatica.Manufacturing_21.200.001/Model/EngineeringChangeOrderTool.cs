using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeOrderTool : Entity
	{

		[DataMember(Name="ChangeStatus", EmitDefaultValue=false)]
		public StringValue ChangeStatus { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="ECOID", EmitDefaultValue=false)]
		public StringValue ECOID { get; set; }

		[DataMember(Name="LineID", EmitDefaultValue=false)]
		public IntValue LineID { get; set; }

		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue OperationID { get; set; }

		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public DecimalValue QtyRequired { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

		[DataMember(Name="ToolID", EmitDefaultValue=false)]
		public StringValue ToolID { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue UnitCost { get; set; }

	}
}