using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class ProjectTaskToCRMLink : Entity
	{

		/// <summary>
		/// DAC Field Name: CampaignID 
		/// DAC: PX.Objects.CR.CRCampaign 
		/// Display Name: Campaign ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="AccountedCampaign", EmitDefaultValue=false)]
		public StringValue? AccountedCampaign { get; set; }

	}
}