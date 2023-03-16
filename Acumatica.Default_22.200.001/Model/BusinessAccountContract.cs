using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class BusinessAccountContract : Entity
	{

		[DataMember(Name="BusinessAccountID", EmitDefaultValue=false)]
		public StringValue BusinessAccountID { get; set; }

		[DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
		public StringValue BusinessAccountName { get; set; }

		[DataMember(Name="ContractID", EmitDefaultValue=false)]
		public StringValue ContractID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue ExpirationDate { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

	}
}