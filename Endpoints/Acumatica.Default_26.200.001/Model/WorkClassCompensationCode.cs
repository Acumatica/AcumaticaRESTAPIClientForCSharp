using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM209800</c> in the Acumatica ERP
	/// <para>Key Fields: WCCCode</para>
	/// </summary>
	public class WorkClassCompensationCode : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// The unique identifier of the workers' compensation code.
		/// <para>DAC Field Name: WorkCodeID</para>
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// <para>Display Name: WCC Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? WCCCode { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the workers' compensation code is active and can be used.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// The description of the workers' compensation code.
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The identifier of the cost code that defines the start of the cost code range.The field is included in CostCodeFrom.
		/// <para>DAC: PX.Objects.PM.PMWorkCodeCostCodeRange</para>
		/// <para>Display Name: Cost Code From</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? CostCodeFrom { get; set; }

		/// <summary>
		/// The identifier of the cost code that defines the end of the cost code range.The field is included in CostCodeTo.
		/// <para>DAC: PX.Objects.PM.PMWorkCodeCostCodeRange</para>
		/// <para>Display Name: Cost Code To</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? CostCodeTo { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(WorkClassCompensationCode)} - \"{WCCCode}\"";
		}

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
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}