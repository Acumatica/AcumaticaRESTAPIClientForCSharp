using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ManageFinancialPeriods : Entity
	{

		[DataMember(Name="ActionToPerform", EmitDefaultValue=false)]
		public StringValue ActionToPerform { get; set; }

		[DataMember(Name="Company", EmitDefaultValue=false)]
		public StringValue Company { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ManageFinancialPeriodsDetail> Details { get; set; }

		[DataMember(Name="FromYear", EmitDefaultValue=false)]
		public StringValue FromYear { get; set; }

		[DataMember(Name="ReopenFinancialPeriodsinAllModules", EmitDefaultValue=false)]
		public BooleanValue ReopenFinancialPeriodsinAllModules { get; set; }

		[DataMember(Name="ToYear", EmitDefaultValue=false)]
		public StringValue ToYear { get; set; }

	}
}