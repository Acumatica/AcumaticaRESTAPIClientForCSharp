using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CompaniesStructureDetail : Entity_v4
	{

		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue BaseCurrencyID { get; set; }

		[DataMember(Name="BranchCountry", EmitDefaultValue=false)]
		public StringValue BranchCountry { get; set; }

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue BranchID { get; set; }

		[DataMember(Name="BranchName", EmitDefaultValue=false)]
		public StringValue BranchName { get; set; }

		[DataMember(Name="BranchStatus", EmitDefaultValue=false)]
		public BooleanValue BranchStatus { get; set; }

		[DataMember(Name="CompanyID", EmitDefaultValue=false)]
		public StringValue CompanyID { get; set; }

		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue CompanyName { get; set; }

		[DataMember(Name="CompanyStatus", EmitDefaultValue=false)]
		public BooleanValue CompanyStatus { get; set; }

		[DataMember(Name="CompanyType", EmitDefaultValue=false)]
		public StringValue CompanyType { get; set; }

	}
}