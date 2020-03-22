using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ManageFinancialPeriodsDetail : Entity
	{

		[DataMember(Name="ClosedinAP", EmitDefaultValue=false)]
		public BooleanValue ClosedinAP { get; set; }

		[DataMember(Name="ClosedinAR", EmitDefaultValue=false)]
		public BooleanValue ClosedinAR { get; set; }

		[DataMember(Name="ClosedinCA", EmitDefaultValue=false)]
		public BooleanValue ClosedinCA { get; set; }

		[DataMember(Name="ClosedinFA", EmitDefaultValue=false)]
		public BooleanValue ClosedinFA { get; set; }

		[DataMember(Name="ClosedinIN", EmitDefaultValue=false)]
		public BooleanValue ClosedinIN { get; set; }

		[DataMember(Name="DescriptionDescription", EmitDefaultValue=false)]
		public StringValue DescriptionDescription { get; set; }

		[DataMember(Name="FinancialPeriodID", EmitDefaultValue=false)]
		public StringValue FinancialPeriodID { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue Selected { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

	}
}