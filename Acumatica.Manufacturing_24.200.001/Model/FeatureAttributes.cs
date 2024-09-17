using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class FeatureAttributes : Entity
	{

		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue? AttributeID { get; set; }

		[DataMember(Name="DefaultValue", EmitDefaultValue=false)]
		public StringValue? DefaultValue { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue? Enabled { get; set; }

		[DataMember(Name="FeatureID", EmitDefaultValue=false)]
		public StringValue? FeatureID { get; set; }

		[DataMember(Name="IsFormula", EmitDefaultValue=false)]
		public BooleanValue? IsFormula { get; set; }

		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue? Required { get; set; }

		[DataMember(Name="Variable", EmitDefaultValue=false)]
		public StringValue? Variable { get; set; }

		[DataMember(Name="Visible", EmitDefaultValue=false)]
		public BooleanValue? Visible { get; set; }

	}
}