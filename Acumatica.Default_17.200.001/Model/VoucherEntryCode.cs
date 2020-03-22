using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class VoucherEntryCode : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue Module { get; set; }

		[DataMember(Name="ModuleTransactionType", EmitDefaultValue=false)]
		public StringValue ModuleTransactionType { get; set; }

		[DataMember(Name="UniqueTransactionCode", EmitDefaultValue=false)]
		public StringValue UniqueTransactionCode { get; set; }

	}
}