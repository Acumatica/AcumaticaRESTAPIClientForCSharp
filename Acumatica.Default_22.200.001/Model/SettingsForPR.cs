using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class SettingsForPR : Entity_v4
	{

		[DataMember(Name="ExportScenario", EmitDefaultValue=false)]
		public StringValue ExportScenario { get; set; }

		[DataMember(Name="PRProcessing", EmitDefaultValue=false)]
		public StringValue PRProcessing { get; set; }

		[DataMember(Name="Report", EmitDefaultValue=false)]
		public StringValue Report { get; set; }

	}
}