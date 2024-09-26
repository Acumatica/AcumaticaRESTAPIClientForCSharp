using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AR303010 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CustomerPaymentMethod : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CardAccountNbr", EmitDefaultValue=false)]
		public StringValue? CardAccountNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CashAccountID 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerCCPID 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerProfileID", EmitDefaultValue=false)]
		public StringValue? CustomerProfileID { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CustomerPaymentMethodDetail>? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PMInstanceID 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InstanceID", EmitDefaultValue=false)]
		public IntValue? InstanceID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PaymentMethodID 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CCProcessingCenterID 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProcCenterID", EmitDefaultValue=false)]
		public StringValue? ProcCenterID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DisplayCardType 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CardType", EmitDefaultValue=false)]
		public StringValue? CardType { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}