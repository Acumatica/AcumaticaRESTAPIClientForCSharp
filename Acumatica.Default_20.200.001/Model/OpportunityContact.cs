using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class OpportunityContact : Entity_v4
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

		[DataMember(Name="FirstName", EmitDefaultValue=false)]
		public StringValue FirstName { get; set; }

		[DataMember(Name="LastName", EmitDefaultValue=false)]
		public StringValue LastName { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue Phone1 { get; set; }

		[DataMember(Name="Phone1Type", EmitDefaultValue=false)]
		public StringValue Phone1Type { get; set; }

		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue Phone2 { get; set; }

		[DataMember(Name="Phone2Type", EmitDefaultValue=false)]
		public StringValue Phone2Type { get; set; }

		[DataMember(Name="Phone3", EmitDefaultValue=false)]
		public StringValue Phone3 { get; set; }

		[DataMember(Name="Phone3Type", EmitDefaultValue=false)]
		public StringValue Phone3Type { get; set; }

		[DataMember(Name="Position", EmitDefaultValue=false)]
		public StringValue Position { get; set; }

		[DataMember(Name="Title", EmitDefaultValue=false)]
		public StringValue Title { get; set; }

		[DataMember(Name="WebSite", EmitDefaultValue=false)]
		public StringValue WebSite { get; set; }

	}
}