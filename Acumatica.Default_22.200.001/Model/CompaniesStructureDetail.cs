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
	public class CompaniesStructureDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: Branch_baseCuryID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: Branch_countryID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="BranchCountry", EmitDefaultValue=false)]
		public StringValue? BranchCountry { get; set; }

		/// <summary>
		/// DAC Field Name: Branch_branchCD 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// DAC Field Name: BAccount_acctName 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="BranchName", EmitDefaultValue=false)]
		public StringValue? BranchName { get; set; }

		/// <summary>
		/// DAC Field Name: Branch_active 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="BranchStatus", EmitDefaultValue=false)]
		public BooleanValue? BranchStatus { get; set; }

		/// <summary>
		/// DAC Field Name: Organization_organizationCD 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="CompanyID", EmitDefaultValue=false)]
		public StringValue? CompanyID { get; set; }

		/// <summary>
		/// DAC Field Name: Organization_organizationName 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// DAC Field Name: Organization_active 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="CompanyStatus", EmitDefaultValue=false)]
		public BooleanValue? CompanyStatus { get; set; }

		/// <summary>
		/// DAC Field Name: Organization_organizationType 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="CompanyType", EmitDefaultValue=false)]
		public StringValue? CompanyType { get; set; }

	}
}