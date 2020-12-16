using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class FinancialSettings : Entity_v4
	{

		[DataMember(Name="BillSeparately", EmitDefaultValue=false)]
		public BooleanValue BillSeparately { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="CashDiscountDate", EmitDefaultValue=false)]
		public DateTimeValue CashDiscountDate { get; set; }

		[DataMember(Name="CustomerTaxZone", EmitDefaultValue=false)]
		public StringValue CustomerTaxZone { get; set; }

		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue DueDate { get; set; }

		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue EntityUsageType { get; set; }

		[DataMember(Name="InvoiceDate", EmitDefaultValue=false)]
		public DateTimeValue InvoiceDate { get; set; }

		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue InvoiceNbr { get; set; }

		[DataMember(Name="OriginalOrderNbr", EmitDefaultValue=false)]
		public StringValue OriginalOrderNbr { get; set; }

		[DataMember(Name="OriginalOrderType", EmitDefaultValue=false)]
		public StringValue OriginalOrderType { get; set; }

		[DataMember(Name="OverrideTaxZone", EmitDefaultValue=false)]
		public BooleanValue OverrideTaxZone { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue PostPeriod { get; set; }

		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue Terms { get; set; }

	}
}