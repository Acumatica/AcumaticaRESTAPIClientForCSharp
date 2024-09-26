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
	/// Corresponds to the screen PM307000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProFormaInvoice : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryAmountDue 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AmountDue", EmitDefaultValue=false)]
		public DecimalValue? AmountDue { get; set; }

		[DataMember(Name="ApprovalDetails", EmitDefaultValue=false)]
		public List<Approval>? ApprovalDetails { get; set; }

		[DataMember(Name="BillingSettings", EmitDefaultValue=false)]
		public BillToSettings? BillingSettings { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		[DataMember(Name="FinancialDetails", EmitDefaultValue=false)]
		public ProFormaFinancialDetails? FinancialDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Hold 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InvoiceDate 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InvoiceDate", EmitDefaultValue=false)]
		public DateTimeValue? InvoiceDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryDocTotal 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InvoiceTotal", EmitDefaultValue=false)]
		public DecimalValue? InvoiceTotal { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		[DataMember(Name="ProgressBilling", EmitDefaultValue=false)]
		public List<ProgressBilling>? ProgressBilling { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryProgressiveTotal 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProgressBillingTotal", EmitDefaultValue=false)]
		public DecimalValue? ProgressBillingTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryRetainageTotal 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RetainageTotal", EmitDefaultValue=false)]
		public DecimalValue? RetainageTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<ProFormaTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.PM.PMProformaRevision 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="TimeAndMaterial", EmitDefaultValue=false)]
		public List<TimeAndMaterial>? TimeAndMaterial { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryTransactionalTotal 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TimeAndMaterialTotal", EmitDefaultValue=false)]
		public DecimalValue? TimeAndMaterialTotal { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}