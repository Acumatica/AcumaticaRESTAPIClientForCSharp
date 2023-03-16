using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class GarnishmentDetails : Entity
	{

		[DataMember(Name="GarnCourtDate", EmitDefaultValue=false)]
		public DateTimeValue GarnCourtDate { get; set; }

		[DataMember(Name="GarnCourtName", EmitDefaultValue=false)]
		public StringValue GarnCourtName { get; set; }

		[DataMember(Name="GarnDocRefNbr", EmitDefaultValue=false)]
		public StringValue GarnDocRefNbr { get; set; }

		[DataMember(Name="GarnOrigAmount", EmitDefaultValue=false)]
		public DecimalValue GarnOrigAmount { get; set; }

		[DataMember(Name="GarnPaidAmount", EmitDefaultValue=false)]
		public DecimalValue GarnPaidAmount { get; set; }

		[DataMember(Name="GarnVendorID", EmitDefaultValue=false)]
		public StringValue GarnVendorID { get; set; }

		[DataMember(Name="GarnVendorInvDescr", EmitDefaultValue=false)]
		public StringValue GarnVendorInvDescr { get; set; }

	}
}