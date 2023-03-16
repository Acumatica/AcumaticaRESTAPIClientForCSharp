using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ECRReferenceDesignator : Entity
	{

		[DataMember(Name="ChangeStatus", EmitDefaultValue=false)]
		public StringValue ChangeStatus { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="ECRID", EmitDefaultValue=false)]
		public StringValue ECRID { get; set; }

		[DataMember(Name="LineID", EmitDefaultValue=false)]
		public IntValue LineID { get; set; }

		[DataMember(Name="MaterialLineID", EmitDefaultValue=false)]
		public IntValue MaterialLineID { get; set; }

		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue OperationID { get; set; }

		[DataMember(Name="RefDes", EmitDefaultValue=false)]
		public StringValue RefDes { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

	}
}