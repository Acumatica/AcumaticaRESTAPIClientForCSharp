using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeRequestOverhead : Entity_v4
	{

		[DataMember(Name="ChangeStatus", EmitDefaultValue=false)]
		public StringValue ChangeStatus { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="ECRID", EmitDefaultValue=false)]
		public StringValue ECRID { get; set; }

		[DataMember(Name="Factor", EmitDefaultValue=false)]
		public DecimalValue Factor { get; set; }

		[DataMember(Name="LineID", EmitDefaultValue=false)]
		public IntValue LineID { get; set; }

		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue OperationID { get; set; }

		[DataMember(Name="OverheadID", EmitDefaultValue=false)]
		public StringValue OverheadID { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

	}
}