using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class ReportingSettings : Entity
	{

		[DataMember(Name="ReportingGroups", EmitDefaultValue=false)]
		public List<ReportingGroup> ReportingGroups { get; set; }

		[DataMember(Name="TaxAgency", EmitDefaultValue=false)]
		public StringValue TaxAgency { get; set; }

	}
}