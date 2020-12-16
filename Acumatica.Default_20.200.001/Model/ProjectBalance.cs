using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProjectBalance : Entity_v4
	{

		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue AccountGroup { get; set; }

		[DataMember(Name="ActualAmount", EmitDefaultValue=false)]
		public DecimalValue ActualAmount { get; set; }

		[DataMember(Name="ActualOpenCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue ActualOpenCommittedAmount { get; set; }

		[DataMember(Name="BudgetedCOAmount", EmitDefaultValue=false)]
		public DecimalValue BudgetedCOAmount { get; set; }

		[DataMember(Name="CommittedCOAmount", EmitDefaultValue=false)]
		public DecimalValue CommittedCOAmount { get; set; }

		[DataMember(Name="CommittedInvoicedAmount", EmitDefaultValue=false)]
		public DecimalValue CommittedInvoicedAmount { get; set; }

		[DataMember(Name="CommittedOpenAmount", EmitDefaultValue=false)]
		public DecimalValue CommittedOpenAmount { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="OriginalBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue OriginalBudgetedAmount { get; set; }

		[DataMember(Name="OriginalCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue OriginalCommittedAmount { get; set; }

		[DataMember(Name="Performance", EmitDefaultValue=false)]
		public DecimalValue Performance { get; set; }

		[DataMember(Name="RevisedBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue RevisedBudgetedAmount { get; set; }

		[DataMember(Name="RevisedCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue RevisedCommittedAmount { get; set; }

		[DataMember(Name="VarianceAmount", EmitDefaultValue=false)]
		public DecimalValue VarianceAmount { get; set; }

	}
}