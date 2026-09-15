using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

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
	[DataContract]
	public class PaymentMethod : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AllowedCashAccounts", EmitDefaultValue=false)]
		public List<PaymentMethodAllowedCashAccountDetail>? AllowedCashAccounts { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARIsProcessingRequired</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Integrated Processing</para>
		/// </summary>
		[DataMember(Name="IntegratedProcessing", EmitDefaultValue=false)]
		public BooleanValue? IntegratedProcessing { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentType</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Means of Payment</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="MeansOfPayment", EmitDefaultValue=false)]
		public StringValue? MeansOfPayment { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name:  Payment Method ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="PaymentMethodID", EmitDefaultValue=false)]
		public StringValue? PaymentMethodID { get; set; }

		[DataMember(Name="ProcessingCenters", EmitDefaultValue=false)]
		public List<PaymentMethodProcessingCenterDetail>? ProcessingCenters { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseForCA</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Require Remittance Information for Cash Account</para>
		/// </summary>
		[DataMember(Name="RequireRemittanceInformationforCashAccount", EmitDefaultValue=false)]
		public BooleanValue? RequireRemittanceInformationforCashAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseForAP</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Use in AP</para>
		/// </summary>
		[DataMember(Name="UseInAP", EmitDefaultValue=false)]
		public BooleanValue? UseInAP { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseForAR</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Use in AR</para>
		/// </summary>
		[DataMember(Name="UseInAR", EmitDefaultValue=false)]
		public BooleanValue? UseInAR { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseForPR</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Use in PR</para>
		/// </summary>
		[DataMember(Name="UseInPR", EmitDefaultValue=false)]
		public BooleanValue? UseInPR { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentDateToBankDate</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Set Payment Date to Bank Transaction Date</para>
		/// </summary>
		[DataMember(Name="SetPaymentDatetoBankTransactionDate", EmitDefaultValue=false)]
		public BooleanValue? SetPaymentDatetoBankTransactionDate { get; set; }

		[DataMember(Name="SettingsForPR", EmitDefaultValue=false)]
		public SettingsForPR? SettingsForPR { get; set; }

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