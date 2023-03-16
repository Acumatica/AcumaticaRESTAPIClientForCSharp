using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class WorkCenterSubstitute : Entity
	{

		[DataMember(Name="SubstituteWorkCenter", EmitDefaultValue=false)]
		public StringValue SubstituteWorkCenter { get; set; }

		[DataMember(Name="UpdateOperationDescription", EmitDefaultValue=false)]
		public BooleanValue UpdateOperationDescription { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}