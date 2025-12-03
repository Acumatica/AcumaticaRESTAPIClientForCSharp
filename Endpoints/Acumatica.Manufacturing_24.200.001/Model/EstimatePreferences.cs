using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM103000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class EstimatePreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: AutoNumberRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Auto Number Revisions</para>
		/// </summary>
		[DataMember(Name="AutoNumberRevisions", EmitDefaultValue=false)]
		public BooleanValue? AutoNumberRevisions { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultEstimateClassID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Default Estimate Class</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="DefaultEstimateClass", EmitDefaultValue=false)]
		public StringValue? DefaultEstimateClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultOrderType</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Default Prod. Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="DefaultProdOrderType", EmitDefaultValue=false)]
		public StringValue? DefaultProdOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Default Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="DefaultRevision", EmitDefaultValue=false)]
		public StringValue? DefaultRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultWorkCenterID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Default Work Center</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="DefaultWorkCenter", EmitDefaultValue=false)]
		public StringValue? DefaultWorkCenter { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EstimateNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Estimate Number Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="EstimateNumberSequence", EmitDefaultValue=false)]
		public StringValue? EstimateNumberSequence { get; set; }

		/// <summary>
		/// During new revision of an estimate, should the new revision automatically be marked as the primary revision
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: New Revision Is Primary</para>
		/// </summary>
		[DataMember(Name="NewRevisionIsPrimary", EmitDefaultValue=false)]
		public BooleanValue? NewRevisionIsPrimary { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Update All Revisions</para>
		/// </summary>
		[DataMember(Name="UpdateAllRevisions", EmitDefaultValue=false)]
		public BooleanValue? UpdateAllRevisions { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateSetup</para>
		/// <para>Display Name: Update Price Info</para>
		/// </summary>
		[DataMember(Name="UpdatePriceInfo", EmitDefaultValue=false)]
		public BooleanValue? UpdatePriceInfo { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}