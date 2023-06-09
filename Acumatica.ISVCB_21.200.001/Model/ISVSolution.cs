using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_21_200_001.Model
{
	[DataContract]
	public class ISVSolution : Entity
	{

		[DataMember(Name="Initials", EmitDefaultValue=false)]
		public StringValue Initials { get; set; }

		[DataMember(Name="SolutionCode", EmitDefaultValue=false)]
		public StringValue SolutionCode { get; set; }

		[DataMember(Name="SolutionClass", EmitDefaultValue=false)]
		public StringValue SolutionClass { get; set; }

		[DataMember(Name="SolutionName", EmitDefaultValue=false)]
		public StringValue SolutionName { get; set; }

		[DataMember(Name="ISV", EmitDefaultValue=false)]
		public StringValue ISV { get; set; }

		[DataMember(Name="SolutionStage", EmitDefaultValue=false)]
		public StringValue SolutionStage { get; set; }

		[DataMember(Name="TAM", EmitDefaultValue=false)]
		public StringValue TAM { get; set; }

		[DataMember(Name="TAMEmployeeName", EmitDefaultValue=false)]
		public StringValue TAMEmployeeName { get; set; }

		[DataMember(Name="ISVCERTND", EmitDefaultValue=false)]
		public StringValue ISVCERTND { get; set; }

		[DataMember(Name="Customers", EmitDefaultValue=false)]
		public List<Customers> Customers { get; set; }

		[DataMember(Name="Repository", EmitDefaultValue=false)]
		public List<RepositoryLines> Repository { get; set; }

	}
}