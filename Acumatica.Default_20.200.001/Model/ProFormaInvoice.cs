using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProFormaInvoice : Entity_v4
	{

		[DataMember(Name="AmountDue", EmitDefaultValue=false)]
		public DecimalValue AmountDue { get; set; }

		[DataMember(Name="ApprovalDetails", EmitDefaultValue=false)]
		public List<Approval> ApprovalDetails { get; set; }

		[DataMember(Name="BillingSettings", EmitDefaultValue=false)]
		public BillToSettings BillingSettings { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue CustomerID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue EffectiveDate { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue ExternalRefNbr { get; set; }

		[DataMember(Name="FinancialDetails", EmitDefaultValue=false)]
		public ProFormaFinancialDetails FinancialDetails { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="InvoiceDate", EmitDefaultValue=false)]
		public DateTimeValue InvoiceDate { get; set; }

		[DataMember(Name="InvoiceTotal", EmitDefaultValue=false)]
		public DecimalValue InvoiceTotal { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue PostPeriod { get; set; }

		[DataMember(Name="ProgressBilling", EmitDefaultValue=false)]
		public List<ProgressBilling> ProgressBilling { get; set; }

		[DataMember(Name="ProgressBillingTotal", EmitDefaultValue=false)]
		public DecimalValue ProgressBillingTotal { get; set; }

		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue ProjectID { get; set; }

		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue RefNbr { get; set; }

		[DataMember(Name="RetainageTotal", EmitDefaultValue=false)]
		public DecimalValue RetainageTotal { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<ProFormaTaxDetail> TaxDetails { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue TaxTotal { get; set; }

		[DataMember(Name="TimeAndMaterial", EmitDefaultValue=false)]
		public List<TimeAndMaterial> TimeAndMaterial { get; set; }

		[DataMember(Name="TimeAndMaterialTotal", EmitDefaultValue=false)]
		public DecimalValue TimeAndMaterialTotal { get; set; }

	}
}