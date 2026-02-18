using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM209800</c> in the Acumatica ERP
	/// <para>Key Fields: WCCCode</para>
	/// </summary>
	public class WorkClassCompensationCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMWorkCodeCostCodeRange</para>
		/// <para>Display Name: Cost Code From</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? CostCodeFrom { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMWorkCodeCostCodeRange</para>
		/// <para>Display Name: Cost Code To</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? CostCodeTo { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkCodeID</para>
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// <para>Display Name: WCC Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? WCCCode { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}