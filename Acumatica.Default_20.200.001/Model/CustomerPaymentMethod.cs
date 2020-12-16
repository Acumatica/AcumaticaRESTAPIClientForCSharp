using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CustomerPaymentMethod : Entity_v4
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="CardAccountNbr", EmitDefaultValue=false)]
		public StringValue CardAccountNbr { get; set; }

		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue CashAccount { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue CustomerID { get; set; }

		[DataMember(Name="CustomerProfileID", EmitDefaultValue=false)]
		public StringValue CustomerProfileID { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CustomerPaymentMethodDetail> Details { get; set; }

		[DataMember(Name="InstanceID", EmitDefaultValue=false)]
		public IntValue InstanceID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue PaymentMethod { get; set; }

		[DataMember(Name="ProcCenterID", EmitDefaultValue=false)]
		public StringValue ProcCenterID { get; set; }

	}
}