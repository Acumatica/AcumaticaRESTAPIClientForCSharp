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
	public class PaymentMethod : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AllowedCashAccounts", EmitDefaultValue=false)]
		public List<PaymentMethodAllowedCashAccountDetail>? AllowedCashAccounts { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="IntegratedProcessing", EmitDefaultValue=false)]
		public BooleanValue? IntegratedProcessing { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="MeansOfPayment", EmitDefaultValue=false)]
		public StringValue? MeansOfPayment { get; set; }

		[DataMember(Name="PaymentMethodID", EmitDefaultValue=false)]
		public StringValue? PaymentMethodID { get; set; }

		[DataMember(Name="ProcessingCenters", EmitDefaultValue=false)]
		public List<PaymentMethodProcessingCenterDetail>? ProcessingCenters { get; set; }

		[DataMember(Name="RequireRemittanceInformationforCashAccount", EmitDefaultValue=false)]
		public BooleanValue? RequireRemittanceInformationforCashAccount { get; set; }

		[DataMember(Name="UseInAP", EmitDefaultValue=false)]
		public BooleanValue? UseInAP { get; set; }

		[DataMember(Name="UseInAR", EmitDefaultValue=false)]
		public BooleanValue? UseInAR { get; set; }

		[DataMember(Name="UseInPR", EmitDefaultValue=false)]
		public BooleanValue? UseInPR { get; set; }

		[DataMember(Name="SetPaymentDatetoBankTransactionDate", EmitDefaultValue=false)]
		public BooleanValue? SetPaymentDatetoBankTransactionDate { get; set; }

		[DataMember(Name="SettingsForPR", EmitDefaultValue=false)]
		public SettingsForPR? SettingsForPR { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string AllowedCashAccounts = "AllowedCashAccounts";
			public const string AllowedCashAccounts_Files = "AllowedCashAccounts/Files";
			public const string ProcessingCenters = "ProcessingCenters";
			public const string ProcessingCenters_Files = "ProcessingCenters/Files";
			public const string SettingsForPR = "SettingsForPR";

			//Intentionally excluded
			//public const string All = "Files,Translations,AllowedCashAccounts,AllowedCashAccounts/Files,ProcessingCenters,ProcessingCenters/Files,SettingsForPR";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}