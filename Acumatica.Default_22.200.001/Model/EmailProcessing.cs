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
	/// Corresponds to the screen SM507000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class EmailProcessing : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Account 
		/// DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public IntValue? Account { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Account_description 
		/// DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccountEmailAccountID", EmitDefaultValue=false)]
		public StringValue? AccountEmailAccountID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MyOwner 
		/// DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AssignedToMe", EmitDefaultValue=false)]
		public BooleanValue? AssignedToMe { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID 
		/// DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AssignedToOwner", EmitDefaultValue=false)]
		public StringValue? AssignedToOwner { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IncludeFailed 
		/// DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IncludeFailed", EmitDefaultValue=false)]
		public BooleanValue? IncludeFailed { get; set; }

		[DataMember(Name="Result", EmitDefaultValue=false)]
		public List<EmailProcessingRow>? Result { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Type 
		/// DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}