using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class PTOBankGLAccounts : Entity_v4
	{

		[DataMember(Name="AssetAccount", EmitDefaultValue=false)]
		public StringValue AssetAccount { get; set; }

		[DataMember(Name="AssetSub", EmitDefaultValue=false)]
		public StringValue AssetSub { get; set; }

		[DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
		public StringValue ExpenseAccount { get; set; }

		[DataMember(Name="ExpenseSub", EmitDefaultValue=false)]
		public StringValue ExpenseSub { get; set; }

		[DataMember(Name="LiabilityAccount", EmitDefaultValue=false)]
		public StringValue LiabilityAccount { get; set; }

		[DataMember(Name="LiabilitySub", EmitDefaultValue=false)]
		public StringValue LiabilitySub { get; set; }

	}
}