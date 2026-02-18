using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.GLConsolidation_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL103004</c> in the Acumatica ERP
	/// <para>Key Fields: OrganizationCD</para>
	/// </summary>
	public class Organization : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The name of the organization.
		/// <para>DAC: PX.Objects.GL.DAC.Organization</para>
		/// <para>Display Name: Company Name</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? OrganizationName { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.DAC.Organization</para>
		/// <para>Display Name: Company ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrganizationCD { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Ledger__LedgerCD</para>
		/// <para>DAC: PX.Objects.GL.DAC.Organization</para>
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