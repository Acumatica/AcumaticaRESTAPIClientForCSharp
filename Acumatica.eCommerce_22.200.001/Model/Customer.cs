using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AR303000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Customer : Acumatica.Default_22_200_001.Model.Customer, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Email 
		/// DAC: PX.Objects.CS.NotificationRecipient 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PrimaryContactID 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PrimaryContactID", EmitDefaultValue=false)]
		public IntValue? PrimaryContactID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerCategory 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerCategory", EmitDefaultValue=false)]
		public StringValue? CustomerCategory { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}