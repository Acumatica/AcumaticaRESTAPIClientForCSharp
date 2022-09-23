using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class CompensationDetail : Entity_v4
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="EarningCode", EmitDefaultValue=false)]
		public StringValue EarningCode { get; set; }

		[DataMember(Name="EarningDescription", EmitDefaultValue=false)]
		public StringValue EarningDescription { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public StringValue LastModifiedDateTime { get; set; }

		[DataMember(Name="PayRate", EmitDefaultValue=false)]
		public DecimalValue PayRate { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="UnitOfPay", EmitDefaultValue=false)]
		public StringValue UnitOfPay { get; set; }

	}
}