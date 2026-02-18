using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class LedgerCompanies : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Organization__Active</para>
		/// <para>DAC: PX.Objects.GL.DAC.OrganizationLedgerLink</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrganizationID</para>
		/// <para>DAC: PX.Objects.GL.DAC.OrganizationLedgerLink</para>
		/// Key Field
		/// </summary>
		public StringValue? Company { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Organization__OrganizationName</para>
		/// <para>DAC: PX.Objects.GL.Branch</para>
		/// </summary>
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Organization__OrganizationType</para>
		/// <para>DAC: PX.Objects.GL.DAC.OrganizationLedgerLink</para>
		/// </summary>
		public StringValue? CompanyType { get; set; }

	}
}