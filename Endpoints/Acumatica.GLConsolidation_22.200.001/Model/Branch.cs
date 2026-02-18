using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.GLConsolidation_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL103002</c> in the Acumatica ERP
	/// <para>Key Fields: BranchCD</para>
	/// </summary>
	public class Branch : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The name of the branch.
		/// <para>DAC: PX.Objects.GL.Branch</para>
		/// <para>Display Name: Branch Name</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? AcctName { get; set; }

		/// <summary>
		/// Key field.User-friendly unique identifier of the Branch.
		/// <para>DAC: PX.Objects.GL.Branch</para>
		/// <para>Display Name: Branch ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? BranchCD { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Organization__OrganizationCD</para>
		/// <para>DAC: PX.Objects.GL.Branch</para>
		/// </summary>
		public StringValue? OrganizationCD { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Ledger__LedgerCD</para>
		/// <para>DAC: PX.Objects.GL.Branch</para>
		/// </summary>
		public StringValue? LedgerCD { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/GLConsolidation/22.200.001";
		}
	}
}