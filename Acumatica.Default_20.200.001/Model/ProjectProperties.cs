using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProjectProperties : Entity_v4
	{

		[DataMember(Name="CertifiedJob", EmitDefaultValue=false)]
		public BooleanValue CertifiedJob { get; set; }

		[DataMember(Name="ChangeOrderWorkflow", EmitDefaultValue=false)]
		public BooleanValue ChangeOrderWorkflow { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="LastRevenueChangeNbr", EmitDefaultValue=false)]
		public StringValue LastRevenueChangeNbr { get; set; }

		[DataMember(Name="ProjectManager", EmitDefaultValue=false)]
		public StringValue ProjectManager { get; set; }

		[DataMember(Name="RestrictEmployees", EmitDefaultValue=false)]
		public BooleanValue RestrictEmployees { get; set; }

		[DataMember(Name="RestrictEquipment", EmitDefaultValue=false)]
		public BooleanValue RestrictEquipment { get; set; }

		[DataMember(Name="RevenueBudgetLevel", EmitDefaultValue=false)]
		public StringValue RevenueBudgetLevel { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="TrackProductionData", EmitDefaultValue=false)]
		public BooleanValue TrackProductionData { get; set; }

	}
}