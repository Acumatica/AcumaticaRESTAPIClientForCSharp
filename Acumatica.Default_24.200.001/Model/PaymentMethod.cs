using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CA204000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PaymentMethod : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AllowedCashAccounts", EmitDefaultValue=false)]
		public List<PaymentMethodAllowedCashAccountDetail>? AllowedCashAccounts { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ARIsProcessingRequired 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IntegratedProcessing", EmitDefaultValue=false)]
		public BooleanValue? IntegratedProcessing { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PaymentType 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MeansOfPayment", EmitDefaultValue=false)]
		public StringValue? MeansOfPayment { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PaymentMethodID 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentMethodID", EmitDefaultValue=false)]
		public StringValue? PaymentMethodID { get; set; }

		[DataMember(Name="ProcessingCenters", EmitDefaultValue=false)]
		public List<PaymentMethodProcessingCenterDetail>? ProcessingCenters { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UseForCA 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequireRemittanceInformationforCashAccount", EmitDefaultValue=false)]
		public BooleanValue? RequireRemittanceInformationforCashAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UseForAP 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseInAP", EmitDefaultValue=false)]
		public BooleanValue? UseInAP { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UseForAR 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseInAR", EmitDefaultValue=false)]
		public BooleanValue? UseInAR { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UseForPR 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseInPR", EmitDefaultValue=false)]
		public BooleanValue? UseInPR { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PaymentDateToBankDate 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SetPaymentDatetoBankTransactionDate", EmitDefaultValue=false)]
		public BooleanValue? SetPaymentDatetoBankTransactionDate { get; set; }

		[DataMember(Name="SettingsForPR", EmitDefaultValue=false)]
		public SettingsForPR? SettingsForPR { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}