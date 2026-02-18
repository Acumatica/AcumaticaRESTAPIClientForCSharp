using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class LedgerBranches : Entity
	{

		/// <summary>
		/// Indicates whether the Branch is active.
		/// <para>DAC: PX.Objects.GL.Branch</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Key field.User-friendly unique identifier of the Branch.
		/// <para>DAC Field Name: BranchCD</para>
		/// <para>DAC: PX.Objects.GL.Branch</para>
		/// <para>Display Name: Branch ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// The name of the branch.
		/// <para>DAC Field Name: AcctName</para>
		/// <para>DAC: PX.Objects.GL.Branch</para>
		/// <para>Display Name: Branch Name</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? BranchName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Organization__OrganizationName</para>
		/// <para>DAC: PX.Objects.GL.Branch</para>
		/// </summary>
		public StringValue? CompanyName { get; set; }

	}
}