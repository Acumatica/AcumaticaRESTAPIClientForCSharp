using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class TaxCodeSetting : Entity
	{

		[DataMember(Name="AdditionalInformation", EmitDefaultValue=false)]
		public StringValue AdditionalInformation { get; set; }

		[DataMember(Name="CompanyNotes", EmitDefaultValue=false)]
		public StringValue CompanyNotes { get; set; }

		[DataMember(Name="FormBox", EmitDefaultValue=false)]
		public StringValue FormBox { get; set; }

		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue Name { get; set; }

		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue Required { get; set; }

		[DataMember(Name="UseDefault", EmitDefaultValue=false)]
		public BooleanValue UseDefault { get; set; }

		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue Value { get; set; }

	}
}