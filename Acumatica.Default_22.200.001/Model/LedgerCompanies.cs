using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class LedgerCompanies : Entity
	{

		/// <summary>
		/// DAC Field Name: Organization__Active 
		/// DAC: PX.Objects.GL.DAC.OrganizationLedgerLink 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC Field Name: OrganizationID 
		/// DAC: PX.Objects.GL.DAC.OrganizationLedgerLink 
		/// Key Field
		/// </summary>
		[DataMember(Name="Company", EmitDefaultValue=false)]
		public StringValue? Company { get; set; }

		/// <summary>
		/// DAC Field Name: Organization__OrganizationName 
		/// DAC: PX.Objects.GL.Branch 
		/// </summary>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// DAC Field Name: Organization__OrganizationType 
		/// DAC: PX.Objects.GL.DAC.OrganizationLedgerLink 
		/// </summary>
		[DataMember(Name="CompanyType", EmitDefaultValue=false)]
		public StringValue? CompanyType { get; set; }

	}
}