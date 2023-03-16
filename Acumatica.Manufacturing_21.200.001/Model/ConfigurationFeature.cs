using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ConfigurationFeature : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="AllowNonInventoryOptions", EmitDefaultValue=false)]
		public BooleanValue AllowNonInventoryOptions { get; set; }

		[DataMember(Name="ConfigurationFeatureAttribute", EmitDefaultValue=false)]
		public List<FeatureAttributes> ConfigurationFeatureAttribute { get; set; }

		[DataMember(Name="ConfigurationFeatureOption", EmitDefaultValue=false)]
		public List<FeatureOptions> ConfigurationFeatureOption { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DisplayOptionAttributes", EmitDefaultValue=false)]
		public BooleanValue DisplayOptionAttributes { get; set; }

		[DataMember(Name="FeatureID", EmitDefaultValue=false)]
		public StringValue FeatureID { get; set; }

		[DataMember(Name="PrintResults", EmitDefaultValue=false)]
		public BooleanValue PrintResults { get; set; }

	}
}