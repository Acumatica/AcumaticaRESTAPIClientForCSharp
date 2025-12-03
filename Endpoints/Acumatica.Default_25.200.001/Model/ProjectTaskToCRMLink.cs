using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class ProjectTaskToCRMLink : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CampaignID</para>
		/// <para>DAC: PX.Objects.CR.CRCampaign</para>
		/// <para>Display Name: Campaign ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="AccountedCampaign", EmitDefaultValue=false)]
		public StringValue? AccountedCampaign { get; set; }

	}
}