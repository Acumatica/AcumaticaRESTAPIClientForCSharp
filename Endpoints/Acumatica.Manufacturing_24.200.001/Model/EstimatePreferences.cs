using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM103000</c> in the Acumatica ERP
	/// </summary>
	public class EstimatePreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: AutoNumberRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Auto Number Revisions</para>
		/// </summary>
		public BooleanValue? AutoNumberRevisions { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultEstimateClassID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Default Estimate Class</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? DefaultEstimateClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultOrderType</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Default Prod. Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? DefaultProdOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Default Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? DefaultRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultWorkCenterID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Default Work Center</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? DefaultWorkCenter { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EstimateNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Estimate Number Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? EstimateNumberSequence { get; set; }

		/// <summary>
		/// During new revision of an estimate, should the new revision automatically be marked as the primary revision
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: New Revision Is Primary</para>
		/// </summary>
		public BooleanValue? NewRevisionIsPrimary { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Update All Revisions</para>
		/// </summary>
		public BooleanValue? UpdateAllRevisions { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Update Price Info</para>
		/// </summary>
		public BooleanValue? UpdatePriceInfo { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}