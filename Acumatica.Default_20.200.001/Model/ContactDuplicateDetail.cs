using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ContactDuplicateDetail : Entity_v4
	{

		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue BusinessAccount { get; set; }

		[DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
		public StringValue BusinessAccountName { get; set; }

		[DataMember(Name="BusinessAccountType", EmitDefaultValue=false)]
		public StringValue BusinessAccountType { get; set; }

		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
		public StringValue DisplayName { get; set; }

		[DataMember(Name="Duplicate", EmitDefaultValue=false)]
		public StringValue Duplicate { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue Email { get; set; }

		[DataMember(Name="LastModifiedDate", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDate { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

	}
}