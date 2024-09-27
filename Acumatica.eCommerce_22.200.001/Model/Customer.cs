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
		/// DAC: PX.Objects.CS.NotificationRecipient 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// The identifier of the Contact object linked with the business account and marked as primary.
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Primary Contact 
		/// </summary>
		/// <remarks>
		/// Also, the Contact.BAccountID value must equal tothe BAccount.BAccountID value of the current business account.
		/// </remarks>
		[DataMember(Name="PrimaryContactID", EmitDefaultValue=false)]
		public IntValue? PrimaryContactID { get; set; }

		/// <summary>
		/// The customer kind, indicating whether the customer is an individual (I) or an organization (O).
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Customer Category 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="CustomerCategory", EmitDefaultValue=false)]
		public StringValue? CustomerCategory { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}