using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Subaccount : Entity_v4
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Secured", EmitDefaultValue=false)]
		public BooleanValue Secured { get; set; }

		[DataMember(Name="SubaccountCD", EmitDefaultValue=false)]
		public StringValue SubaccountCD { get; set; }

		[DataMember(Name="SubaccountID", EmitDefaultValue=false)]
		public IntValue SubaccountID { get; set; }

	}
}