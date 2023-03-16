using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ConfigurationMaintenanceFeature : Entity
	{

		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue ConfigurationID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="FeatureID", EmitDefaultValue=false)]
		public StringValue FeatureID { get; set; }

		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue Label { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="LotQty", EmitDefaultValue=false)]
		public StringValue LotQty { get; set; }

		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public StringValue MaxQty { get; set; }

		[DataMember(Name="MaxSelection", EmitDefaultValue=false)]
		public StringValue MaxSelection { get; set; }

		[DataMember(Name="MinQty", EmitDefaultValue=false)]
		public StringValue MinQty { get; set; }

		[DataMember(Name="MinSelection", EmitDefaultValue=false)]
		public StringValue MinSelection { get; set; }

		[DataMember(Name="Options", EmitDefaultValue=false)]
		public List<ConfigurationMaintFeatureOption> Options { get; set; }

		[DataMember(Name="PrintResults", EmitDefaultValue=false)]
		public BooleanValue PrintResults { get; set; }

		[DataMember(Name="ResultsCopy", EmitDefaultValue=false)]
		public BooleanValue ResultsCopy { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

		[DataMember(Name="Rules", EmitDefaultValue=false)]
		public List<ConfigurationMaintFeatureRule> Rules { get; set; }

		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public IntValue SortOrder { get; set; }

		[DataMember(Name="Visible", EmitDefaultValue=false)]
		public BooleanValue Visible { get; set; }

	}
}