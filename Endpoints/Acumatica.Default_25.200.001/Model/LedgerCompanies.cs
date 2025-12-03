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
	public class LedgerCompanies : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Organization__Active</para>
		/// <para>DAC: PX.Objects.GL.DAC.OrganizationLedgerLink</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrganizationID</para>
		/// <para>DAC: PX.Objects.GL.DAC.OrganizationLedgerLink</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Company", EmitDefaultValue=false)]
		public StringValue? Company { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Organization__OrganizationName</para>
		/// <para>DAC: PX.Objects.GL.Branch</para>
		/// </summary>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Organization__OrganizationType</para>
		/// <para>DAC: PX.Objects.GL.DAC.OrganizationLedgerLink</para>
		/// </summary>
		[DataMember(Name="CompanyType", EmitDefaultValue=false)]
		public StringValue? CompanyType { get; set; }

	}
}