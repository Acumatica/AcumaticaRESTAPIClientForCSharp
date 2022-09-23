using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class BatchOvertimeRules : Entity_v4
	{

		[DataMember(Name="ApplyOvertimeRulesfortheDocument", EmitDefaultValue=false)]
		public BooleanValue ApplyOvertimeRulesfortheDocument { get; set; }

		[DataMember(Name="OvertimeRulesDetails", EmitDefaultValue=false)]
		public List<BatchOvertimeRulesDetail> OvertimeRulesDetails { get; set; }

	}
}