using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class PaymentMethod : Entity_v4
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="AllowedCashAccounts", EmitDefaultValue=false)]
		public List<PaymentMethodAllowedCashAccountDetail> AllowedCashAccounts { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="IntegratedProcessing", EmitDefaultValue=false)]
		public BooleanValue IntegratedProcessing { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="MeansOfPayment", EmitDefaultValue=false)]
		public StringValue MeansOfPayment { get; set; }

		[DataMember(Name="PaymentMethodID", EmitDefaultValue=false)]
		public StringValue PaymentMethodID { get; set; }

		[DataMember(Name="ProcessingCenters", EmitDefaultValue=false)]
		public List<PaymentMethodProcessingCenterDetail> ProcessingCenters { get; set; }

		[DataMember(Name="RequireRemittanceInformationforCashAccount", EmitDefaultValue=false)]
		public BooleanValue RequireRemittanceInformationforCashAccount { get; set; }

		[DataMember(Name="UseInAP", EmitDefaultValue=false)]
		public BooleanValue UseInAP { get; set; }

		[DataMember(Name="UseInAR", EmitDefaultValue=false)]
		public BooleanValue UseInAR { get; set; }

	}
}