using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class ProFormaInvoice : Entity, ITopLevelEntity
	{

		[DataMember(Name="AmountDue", EmitDefaultValue=false)]
		public DecimalValue? AmountDue { get; set; }

		[DataMember(Name="ApprovalDetails", EmitDefaultValue=false)]
		public List<Approval>? ApprovalDetails { get; set; }

		[DataMember(Name="BillingSettings", EmitDefaultValue=false)]
		public BillToSettings? BillingSettings { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		[DataMember(Name="FinancialDetails", EmitDefaultValue=false)]
		public ProFormaFinancialDetails? FinancialDetails { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="InvoiceDate", EmitDefaultValue=false)]
		public DateTimeValue? InvoiceDate { get; set; }

		[DataMember(Name="InvoiceTotal", EmitDefaultValue=false)]
		public DecimalValue? InvoiceTotal { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		[DataMember(Name="ProgressBilling", EmitDefaultValue=false)]
		public List<ProgressBilling>? ProgressBilling { get; set; }

		[DataMember(Name="ProgressBillingTotal", EmitDefaultValue=false)]
		public DecimalValue? ProgressBillingTotal { get; set; }

		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		[DataMember(Name="RetainageTotal", EmitDefaultValue=false)]
		public DecimalValue? RetainageTotal { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<ProFormaTaxDetail>? TaxDetails { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="TimeAndMaterial", EmitDefaultValue=false)]
		public List<TimeAndMaterial>? TimeAndMaterial { get; set; }

		[DataMember(Name="TimeAndMaterialTotal", EmitDefaultValue=false)]
		public DecimalValue? TimeAndMaterialTotal { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string ApprovalDetails = "ApprovalDetails";
			public const string ApprovalDetails_Files = "ApprovalDetails/Files";
			public const string BillingSettings = "BillingSettings";
			public const string BillingSettings_BillToAddress = "BillingSettings/BillToAddress";
			public const string BillingSettings_BillToContact = "BillingSettings/BillToContact";
			public const string FinancialDetails = "FinancialDetails";
			public const string ProgressBilling = "ProgressBilling";
			public const string ProgressBilling_Files = "ProgressBilling/Files";
			public const string TaxDetails = "TaxDetails";
			public const string TaxDetails_Files = "TaxDetails/Files";
			public const string TimeAndMaterial = "TimeAndMaterial";
			public const string TimeAndMaterial_Files = "TimeAndMaterial/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,ApprovalDetails,ApprovalDetails/Files,BillingSettings,BillingSettings/BillToAddress,BillingSettings/BillToContact,FinancialDetails,ProgressBilling,ProgressBilling/Files,TaxDetails,TaxDetails/Files,TimeAndMaterial,TimeAndMaterial/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}