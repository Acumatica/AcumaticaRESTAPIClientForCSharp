using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class LedgerBranches : Entity
	{

		/// <summary>
		/// Indicates whether the Branch is active.
		/// <para>DAC: PX.Objects.GL.Branch</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Key field.User-friendly unique identifier of the Branch.
		/// <para>DAC Field Name: BranchCD</para>
		/// <para>DAC: PX.Objects.GL.Branch</para>
		/// <para>Display Name: Branch ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// The name of the branch.
		/// <para>DAC Field Name: AcctName</para>
		/// <para>DAC: PX.Objects.GL.Branch</para>
		/// <para>Display Name: Branch Name</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="BranchName", EmitDefaultValue=false)]
		public StringValue? BranchName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Organization__OrganizationName</para>
		/// <para>DAC: PX.Objects.GL.Branch</para>
		/// </summary>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}