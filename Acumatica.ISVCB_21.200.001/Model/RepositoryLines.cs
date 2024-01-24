using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_21_200_001.Model
{
	[DataContract]
	public class RepositoryLines : Entity
	{

		[DataMember(Name="AcumaticaBuild", EmitDefaultValue=false)]
		public StringValue? AcumaticaBuild { get; set; }

		[DataMember(Name="Certified", EmitDefaultValue=false)]
		public BooleanValue? Certified { get; set; }

		[DataMember(Name="ISVVersion", EmitDefaultValue=false)]
		public StringValue? ISVVersion { get; set; }

		[DataMember(Name="ClientApplication", EmitDefaultValue=false)]
		public StringValue? ClientApplication { get; set; }

		[DataMember(Name="CustomizationProject", EmitDefaultValue=false)]
		public StringValue? CustomizationProject { get; set; }

		[DataMember(Name="Documentation", EmitDefaultValue=false)]
		public StringValue? Documentation { get; set; }

		[DataMember(Name="IsStatusISVApproved", EmitDefaultValue=false)]
		public BooleanValue? IsStatusISVApproved { get; set; }

		[DataMember(Name="IsStatusPassed", EmitDefaultValue=false)]
		public BooleanValue? IsStatusPassed { get; set; }

		[DataMember(Name="IsStatusSubmitted", EmitDefaultValue=false)]
		public BooleanValue? IsStatusSubmitted { get; set; }

		[DataMember(Name="PortalCustomization", EmitDefaultValue=false)]
		public StringValue? PortalCustomization { get; set; }

		[DataMember(Name="Issues", EmitDefaultValue=false)]
		public StringValue? Issues { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TestFiles", EmitDefaultValue=false)]
		public StringValue? TestFiles { get; set; }

	}
}