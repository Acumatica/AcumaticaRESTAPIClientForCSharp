using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Tax : Entity_v4
	{

		[DataMember(Name="CalculateOn", EmitDefaultValue=false)]
		public StringValue CalculateOn { get; set; }

		[DataMember(Name="CashDiscount", EmitDefaultValue=false)]
		public StringValue CashDiscount { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="DeductibleVAT", EmitDefaultValue=false)]
		public BooleanValue DeductibleVAT { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EnterFromTaxBill", EmitDefaultValue=false)]
		public BooleanValue EnterFromTaxBill { get; set; }

		[DataMember(Name="ExcludeFromTaxonTaxCalculation", EmitDefaultValue=false)]
		public BooleanValue ExcludeFromTaxonTaxCalculation { get; set; }

		[DataMember(Name="IncludeInVATExemptTotal", EmitDefaultValue=false)]
		public BooleanValue IncludeInVATExemptTotal { get; set; }

		[DataMember(Name="IncludeInVATTaxableTotal", EmitDefaultValue=false)]
		public BooleanValue IncludeInVATTaxableTotal { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="NotValidAfter", EmitDefaultValue=false)]
		public DateTimeValue NotValidAfter { get; set; }

		[DataMember(Name="PendingVAT", EmitDefaultValue=false)]
		public BooleanValue PendingVAT { get; set; }

		[DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
		public BooleanValue ReverseVAT { get; set; }

		[DataMember(Name="StatisticalVAT", EmitDefaultValue=false)]
		public BooleanValue StatisticalVAT { get; set; }

		[DataMember(Name="TaxAgency", EmitDefaultValue=false)]
		public StringValue TaxAgency { get; set; }

		[DataMember(Name="TaxClaimableAccount", EmitDefaultValue=false)]
		public StringValue TaxClaimableAccount { get; set; }

		[DataMember(Name="TaxClaimableSubaccount", EmitDefaultValue=false)]
		public StringValue TaxClaimableSubaccount { get; set; }

		[DataMember(Name="TaxExpenseAccount", EmitDefaultValue=false)]
		public StringValue TaxExpenseAccount { get; set; }

		[DataMember(Name="TaxExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue TaxExpenseSubaccount { get; set; }

		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue TaxID { get; set; }

		[DataMember(Name="TaxPayableAccount", EmitDefaultValue=false)]
		public StringValue TaxPayableAccount { get; set; }

		[DataMember(Name="TaxPayableSubaccount", EmitDefaultValue=false)]
		public StringValue TaxPayableSubaccount { get; set; }

		[DataMember(Name="TaxSchedule", EmitDefaultValue=false)]
		public List<TaxScheduleDetail> TaxSchedule { get; set; }

		[DataMember(Name="TaxType", EmitDefaultValue=false)]
		public StringValue TaxType { get; set; }

		[DataMember(Name="Zones", EmitDefaultValue=false)]
		public List<TaxZoneDetail> Zones { get; set; }

	}
}