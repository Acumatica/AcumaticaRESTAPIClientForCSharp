using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class AttributeDetail : Entity_v4
	{

		[DataMember(Name="AttributeBOMID", EmitDefaultValue=false)]
		public StringValue AttributeBOMID { get; set; }

		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue AttributeID { get; set; }

		[DataMember(Name="DefaultValue", EmitDefaultValue=false)]
		public StringValue DefaultValue { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue Enabled { get; set; }

		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue Label { get; set; }

		[DataMember(Name="Level", EmitDefaultValue=false)]
		public StringValue Level { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="OperNbr", EmitDefaultValue=false)]
		public StringValue OperNbr { get; set; }

		[DataMember(Name="OrderFunction", EmitDefaultValue=false)]
		public StringValue OrderFunction { get; set; }

		[DataMember(Name="TransactionRequired", EmitDefaultValue=false)]
		public BooleanValue TransactionRequired { get; set; }

	}
}