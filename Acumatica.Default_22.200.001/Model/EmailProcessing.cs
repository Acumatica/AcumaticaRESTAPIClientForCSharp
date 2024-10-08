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
		/// DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public IntValue? Account { get; set; }

		/// <summary>
		/// DAC Field Name: Account_description 
		/// DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter 
		/// </summary>
		[DataMember(Name="AccountEmailAccountID", EmitDefaultValue=false)]
		public StringValue? AccountEmailAccountID { get; set; }

		/// <summary>
		/// DAC Field Name: MyOwner 
		/// DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter 
		/// </summary>
		[DataMember(Name="AssignedToMe", EmitDefaultValue=false)]
		public BooleanValue? AssignedToMe { get; set; }

		/// <summary>
		/// DAC Field Name: OwnerID 
		/// DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter 
		/// </summary>
		[DataMember(Name="AssignedToOwner", EmitDefaultValue=false)]
		public StringValue? AssignedToOwner { get; set; }

		/// <summary>
		/// DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter 
		/// </summary>
		[DataMember(Name="IncludeFailed", EmitDefaultValue=false)]
		public BooleanValue? IncludeFailed { get; set; }

		[DataMember(Name="Result", EmitDefaultValue=false)]
		public List<EmailProcessingRow>? Result { get; set; }

		/// <summary>
		/// DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}