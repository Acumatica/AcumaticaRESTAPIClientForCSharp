using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class AppTotals : Entity_v4
	{

		[DataMember(Name="ActualTotal", EmitDefaultValue=false)]
		public DecimalValue ActualTotal { get; set; }

		[DataMember(Name="AppointmentBillableTotal", EmitDefaultValue=false)]
		public DecimalValue AppointmentBillableTotal { get; set; }

		[DataMember(Name="AppointmentTotal", EmitDefaultValue=false)]
		public DecimalValue AppointmentTotal { get; set; }

		[DataMember(Name="BillableLaborTotal", EmitDefaultValue=false)]
		public DecimalValue BillableLaborTotal { get; set; }

		[DataMember(Name="BillableTotal", EmitDefaultValue=false)]
		public DecimalValue BillableTotal { get; set; }

		[DataMember(Name="EstimatedTotal", EmitDefaultValue=false)]
		public DecimalValue EstimatedTotal { get; set; }

		[DataMember(Name="LineTotal", EmitDefaultValue=false)]
		public DecimalValue LineTotal { get; set; }

		[DataMember(Name="PrepaymentApplied", EmitDefaultValue=false)]
		public DecimalValue PrepaymentApplied { get; set; }

		[DataMember(Name="PrepaymentReceived", EmitDefaultValue=false)]
		public DecimalValue PrepaymentReceived { get; set; }

		[DataMember(Name="PrepaymentRemaining", EmitDefaultValue=false)]
		public DecimalValue PrepaymentRemaining { get; set; }

		[DataMember(Name="ServiceOrderBillableUnpaidBalance", EmitDefaultValue=false)]
		public DecimalValue ServiceOrderBillableUnpaidBalance { get; set; }

		[DataMember(Name="ServiceOrderTotal", EmitDefaultValue=false)]
		public DecimalValue ServiceOrderTotal { get; set; }

		[DataMember(Name="ServiceOrderUnpaidBalance", EmitDefaultValue=false)]
		public DecimalValue ServiceOrderUnpaidBalance { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue TaxTotal { get; set; }

		[DataMember(Name="VATExemptTotal", EmitDefaultValue=false)]
		public DecimalValue VATExemptTotal { get; set; }

		[DataMember(Name="VATTaxableTotal", EmitDefaultValue=false)]
		public DecimalValue VATTaxableTotal { get; set; }

	}
}