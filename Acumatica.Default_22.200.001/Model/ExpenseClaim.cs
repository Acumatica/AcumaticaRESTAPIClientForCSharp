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
	/// Corresponds to the screen EP301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ExpenseClaim : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ApproveDate 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ApprovalDate", EmitDefaultValue=false)]
		public DateTimeValue? ApprovalDate { get; set; }

		[DataMember(Name="ApprovalDetails", EmitDefaultValue=false)]
		public List<Approval>? ApprovalDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseCuryID 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EmployeeID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ClaimedBy", EmitDefaultValue=false)]
		public StringValue? ClaimedBy { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryDocBal 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ClaimTotal", EmitDefaultValue=false)]
		public DecimalValue? ClaimTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SampleCuryRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DocDate 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DepartmentID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DepartmentID", EmitDefaultValue=false)]
		public StringValue? DepartmentID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ExpenseClaimDetails>? Details { get; set; }

		[DataMember(Name="FinancialDetails", EmitDefaultValue=false)]
		public ExpenseClaimFinancialDetail? FinancialDetails { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerLocationID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SampleRecipRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? ReciprocalRate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<ExpenseClaimTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryVatExemptTotal 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VATExemptTotal", EmitDefaultValue=false)]
		public DecimalValue? VATExemptTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryVatTaxableTotal 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VATTaxableTotal", EmitDefaultValue=false)]
		public DecimalValue? VATTaxableTotal { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}