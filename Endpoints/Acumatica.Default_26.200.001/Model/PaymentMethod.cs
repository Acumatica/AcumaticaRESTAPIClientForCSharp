using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CA204000</c> in the Acumatica ERP
	/// <para>Key Fields: PaymentMethodID</para>
	/// </summary>
	public class PaymentMethod : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name:  Payment Method ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? PaymentMethodID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentType</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Means of Payment</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? MeansOfPayment { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

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

		/// <summary>
		/// <para>DAC Field Name: UseForCA</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Require Remittance Information for Cash Account</para>
		/// </summary>
		public BooleanValue? RequireRemittanceInformationforCashAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARIsProcessingRequired</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Integrated Processing</para>
		/// </summary>
		public BooleanValue? IntegratedProcessing { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

		#region LinkedEntities
		public SettingsForPR? SettingsForPR { get; set; }

		#endregion

		#region Details
		public List<PaymentMethodAllowedCashAccountDetail>? AllowedCashAccounts { get; set; }

		public List<PaymentMethodProcessingCenterDetail>? ProcessingCenters { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(PaymentMethod)} - \"{PaymentMethodID}\"";
		}

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string AllowedCashAccounts = "AllowedCashAccounts";
			public const string ProcessingCenters = "ProcessingCenters";
			public const string SettingsForPR = "SettingsForPR";

			//Intentionally excluded
			//public const string All = "Files,Translations,AllowedCashAccounts,ProcessingCenters,SettingsForPR";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}