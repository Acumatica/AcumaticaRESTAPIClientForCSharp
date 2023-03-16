using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class OrderStepDetail : Entity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="LineID", EmitDefaultValue=false)]
		public IntValue LineID { get; set; }

		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue OperationNbr { get; set; }

		[DataMember(Name="PhantomBomID", EmitDefaultValue=false)]
		public StringValue PhantomBomID { get; set; }

		[DataMember(Name="PhantomBOMLineID", EmitDefaultValue=false)]
		public IntValue PhantomBOMLineID { get; set; }

		[DataMember(Name="PhantomBOMOperNbr", EmitDefaultValue=false)]
		public StringValue PhantomBOMOperNbr { get; set; }

		[DataMember(Name="PhantomLevel", EmitDefaultValue=false)]
		public IntValue PhantomLevel { get; set; }

		[DataMember(Name="PhantomMatlLineID", EmitDefaultValue=false)]
		public IntValue PhantomMatlLineID { get; set; }

		[DataMember(Name="PhantomMatlOperNbr", EmitDefaultValue=false)]
		public StringValue PhantomMatlOperNbr { get; set; }

	}
}