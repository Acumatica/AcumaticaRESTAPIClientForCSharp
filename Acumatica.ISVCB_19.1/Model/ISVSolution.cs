using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.ISVCB_19_1.Model
{
	[DataContract]
	public class ISVSolution : Entity
	{

		[DataMember(Name="SolutionCode", EmitDefaultValue=false)]
		public StringValue SolutionCode { get; set; }

		[DataMember(Name="SolutionName", EmitDefaultValue=false)]
		public StringValue SolutionName { get; set; }

		[DataMember(Name="ISV", EmitDefaultValue=false)]
		public StringValue ISV { get; set; }

		[DataMember(Name="SolutionStage", EmitDefaultValue=false)]
		public StringValue SolutionStage { get; set; }

		[DataMember(Name="Customers", EmitDefaultValue=false)]
		public List<Customers> Customers { get; set; }

		[DataMember(Name="Initials", EmitDefaultValue=false)]
		public StringValue Initials { get; set; }

	}
}