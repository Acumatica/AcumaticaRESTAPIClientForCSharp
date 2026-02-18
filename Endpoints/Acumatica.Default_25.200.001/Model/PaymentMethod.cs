using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CA204000</c> in the Acumatica ERP
	/// <para>Key Fields: PaymentMethodID</para>
	/// </summary>
	public class PaymentMethod : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		public List<PaymentMethodAllowedCashAccountDetail>? AllowedCashAccounts { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARIsProcessingRequired</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Integrated Processing</para>
		/// </summary>
		public BooleanValue? IntegratedProcessing { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentType</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Means of Payment</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? MeansOfPayment { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name:  Payment Method ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? PaymentMethodID { get; set; }

		public List<PaymentMethodProcessingCenterDetail>? ProcessingCenters { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseForCA</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Require Remittance Information for Cash Account</para>
		/// </summary>
		public BooleanValue? RequireRemittanceInformationforCashAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseForAP</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Use in AP</para>
		/// </summary>
		public BooleanValue? UseInAP { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseForAR</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Use in AR</para>
		/// </summary>
		public BooleanValue? UseInAR { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseForPR</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Use in PR</para>
		/// </summary>
		public BooleanValue? UseInPR { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentDateToBankDate</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Set Payment Date to Bank Transaction Date</para>
		/// </summary>
		public BooleanValue? SetPaymentDatetoBankTransactionDate { get; set; }

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
			return "entity/Default/25.200.001";
		}
	}
}