using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen TX205000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Tax : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxCalcRule 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CalculateOn", EmitDefaultValue=false)]
		public StringValue? CalculateOn { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxApplyTermsDisc 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CashDiscount", EmitDefaultValue=false)]
		public StringValue? CashDiscount { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DeductibleVAT 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DeductibleVAT", EmitDefaultValue=false)]
		public BooleanValue? DeductibleVAT { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DirectTax 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EnterFromTaxBill", EmitDefaultValue=false)]
		public BooleanValue? EnterFromTaxBill { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxCalcLevel2Exclude 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExcludeFromTaxonTaxCalculation", EmitDefaultValue=false)]
		public BooleanValue? ExcludeFromTaxonTaxCalculation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExemptTax 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IncludeInVATExemptTotal", EmitDefaultValue=false)]
		public BooleanValue? IncludeInVATExemptTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IncludeInTaxable 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IncludeInVATTaxableTotal", EmitDefaultValue=false)]
		public BooleanValue? IncludeInVATTaxableTotal { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OutDate 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NotValidAfter", EmitDefaultValue=false)]
		public DateTimeValue? NotValidAfter { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PendingTax 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PendingVAT", EmitDefaultValue=false)]
		public BooleanValue? PendingVAT { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReverseTax 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
		public BooleanValue? ReverseVAT { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StatisticalTax 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StatisticalVAT", EmitDefaultValue=false)]
		public BooleanValue? StatisticalVAT { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxVendorID 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxAgency", EmitDefaultValue=false)]
		public StringValue? TaxAgency { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PurchTaxAcctID 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxClaimableAccount", EmitDefaultValue=false)]
		public StringValue? TaxClaimableAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PurchTaxSubID 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxClaimableSubaccount", EmitDefaultValue=false)]
		public StringValue? TaxClaimableSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExpenseAccountID 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxExpenseAccount", EmitDefaultValue=false)]
		public StringValue? TaxExpenseAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExpenseSubID 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? TaxExpenseSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxID 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesTaxAcctID 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxPayableAccount", EmitDefaultValue=false)]
		public StringValue? TaxPayableAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesTaxSubID 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxPayableSubaccount", EmitDefaultValue=false)]
		public StringValue? TaxPayableSubaccount { get; set; }

		[DataMember(Name="TaxSchedule", EmitDefaultValue=false)]
		public List<TaxScheduleDetail>? TaxSchedule { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxType 
		/// DAC: PX.Objects.TX.Tax 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxType", EmitDefaultValue=false)]
		public StringValue? TaxType { get; set; }

		[DataMember(Name="Zones", EmitDefaultValue=false)]
		public List<TaxZoneDetail>? Zones { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}