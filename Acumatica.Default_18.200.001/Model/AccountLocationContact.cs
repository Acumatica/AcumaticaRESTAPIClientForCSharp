using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class AccountLocationContact : Entity
	{

		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue Attention { get; set; }

		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue CompanyName { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue Email { get; set; }

		[DataMember(Name="Fax", EmitDefaultValue=false)]
		public StringValue Fax { get; set; }

		[DataMember(Name="FaxType", EmitDefaultValue=false)]
		public StringValue FaxType { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue Phone1 { get; set; }

		[DataMember(Name="Phone1Type", EmitDefaultValue=false)]
		public StringValue Phone1Type { get; set; }

		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue Phone2 { get; set; }

		[DataMember(Name="Phone2Type", EmitDefaultValue=false)]
		public StringValue Phone2Type { get; set; }

		[DataMember(Name="SameAsMain", EmitDefaultValue=false)]
		public BooleanValue SameAsMain { get; set; }

		[DataMember(Name="WebSite", EmitDefaultValue=false)]
		public StringValue WebSite { get; set; }

	}
}