using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProjectProFormaDetails : Entity_v4
	{

		[DataMember(Name="ARDocDate", EmitDefaultValue=false)]
		public DateTimeValue ARDocDate { get; set; }

		[DataMember(Name="ARDocDescription", EmitDefaultValue=false)]
		public StringValue ARDocDescription { get; set; }

		[DataMember(Name="ARDocOriginalAmount", EmitDefaultValue=false)]
		public DecimalValue ARDocOriginalAmount { get; set; }

		[DataMember(Name="ARDocStatus", EmitDefaultValue=false)]
		public StringValue ARDocStatus { get; set; }

		[DataMember(Name="ARDocType", EmitDefaultValue=false)]
		public StringValue ARDocType { get; set; }

		[DataMember(Name="ARReferenceNbr", EmitDefaultValue=false)]
		public StringValue ARReferenceNbr { get; set; }

		[DataMember(Name="BillingNbr", EmitDefaultValue=false)]
		public IntValue BillingNbr { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="InvoiceTotal", EmitDefaultValue=false)]
		public DecimalValue InvoiceTotal { get; set; }

		[DataMember(Name="OpenARBalance", EmitDefaultValue=false)]
		public DecimalValue OpenARBalance { get; set; }

		[DataMember(Name="OriginalRefNbr", EmitDefaultValue=false)]
		public StringValue OriginalRefNbr { get; set; }

		[DataMember(Name="OriginalRetainage", EmitDefaultValue=false)]
		public DecimalValue OriginalRetainage { get; set; }

		[DataMember(Name="PaidRetainage", EmitDefaultValue=false)]
		public DecimalValue PaidRetainage { get; set; }

		[DataMember(Name="ProFormaDate", EmitDefaultValue=false)]
		public DateTimeValue ProFormaDate { get; set; }

		[DataMember(Name="ProFormaReferenceNbr", EmitDefaultValue=false)]
		public StringValue ProFormaReferenceNbr { get; set; }

		[DataMember(Name="RetainageInvoice", EmitDefaultValue=false)]
		public BooleanValue RetainageInvoice { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TotalAmount", EmitDefaultValue=false)]
		public DecimalValue TotalAmount { get; set; }

		[DataMember(Name="UnpaidRetainage", EmitDefaultValue=false)]
		public DecimalValue UnpaidRetainage { get; set; }

		[DataMember(Name="UnreleasedRetainage", EmitDefaultValue=false)]
		public DecimalValue UnreleasedRetainage { get; set; }

	}
}