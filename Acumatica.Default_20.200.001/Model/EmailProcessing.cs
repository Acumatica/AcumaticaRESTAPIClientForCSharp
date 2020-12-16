using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class EmailProcessing : Entity_v4
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public IntValue Account { get; set; }

		[DataMember(Name="AccountEmailAccountID", EmitDefaultValue=false)]
		public StringValue AccountEmailAccountID { get; set; }

		[DataMember(Name="AssignedToMe", EmitDefaultValue=false)]
		public BooleanValue AssignedToMe { get; set; }

		[DataMember(Name="AssignedToOwner", EmitDefaultValue=false)]
		public StringValue AssignedToOwner { get; set; }

		[DataMember(Name="IncludeFailed", EmitDefaultValue=false)]
		public BooleanValue IncludeFailed { get; set; }

		[DataMember(Name="Result", EmitDefaultValue=false)]
		public List<EmailProcessingRow> Result { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

	}
}