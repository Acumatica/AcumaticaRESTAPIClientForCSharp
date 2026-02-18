using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class CompanyTree : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CR.ContactNotification</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Specifies whether the member is the owner of the workgroup.
		/// <para>DAC Field Name: IsOwner</para>
		/// <para>DAC: PX.TM.EPCompanyTreeMember</para>
		/// </summary>
		public BooleanValue? Owner { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// <para>DAC: PX.Objects.CR.CRPMTimeActivity</para>
		/// <para>Display Name: Workgroup</para>
		/// </summary>
		public StringValue? WorkgroupID { get; set; }

	}
}