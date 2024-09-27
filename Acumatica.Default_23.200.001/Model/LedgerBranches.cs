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
	public class LedgerBranches : Entity
	{

		/// <summary>
		/// Indicates whether the Branch is active.
		/// DAC: PX.Objects.GL.Branch 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Key field.User-friendly unique identifier of the Branch.
		/// DAC Field Name: BranchCD 
		/// DAC: PX.Objects.GL.Branch 
		/// Display Name: Branch ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// The name of the branch.
		/// DAC Field Name: AcctName 
		/// DAC: PX.Objects.GL.Branch 
		/// Display Name: Branch Name 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="BranchName", EmitDefaultValue=false)]
		public StringValue? BranchName { get; set; }

		/// <summary>
		/// DAC Field Name: Organization__OrganizationName 
		/// DAC: PX.Objects.GL.Branch 
		/// </summary>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

	}
}