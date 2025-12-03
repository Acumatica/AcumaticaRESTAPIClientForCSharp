using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class CompaniesStructureDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Branch_baseCuryID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Branch_countryID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="BranchCountry", EmitDefaultValue=false)]
		public StringValue? BranchCountry { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Branch_branchCD</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BAccount_acctName</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="BranchName", EmitDefaultValue=false)]
		public StringValue? BranchName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Branch_active</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="BranchStatus", EmitDefaultValue=false)]
		public BooleanValue? BranchStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Organization_organizationCD</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="CompanyID", EmitDefaultValue=false)]
		public StringValue? CompanyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Organization_organizationName</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Organization_active</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="CompanyStatus", EmitDefaultValue=false)]
		public BooleanValue? CompanyStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Organization_organizationType</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="CompanyType", EmitDefaultValue=false)]
		public StringValue? CompanyType { get; set; }

	}
}