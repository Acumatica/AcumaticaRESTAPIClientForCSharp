using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM103000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class EstimatePreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: AutoNumberRevisionID 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// Display Name: Auto Number Revisions 
		/// </summary>
		[DataMember(Name="AutoNumberRevisions", EmitDefaultValue=false)]
		public BooleanValue? AutoNumberRevisions { get; set; }

		/// <summary>
		/// DAC Field Name: DefaultEstimateClassID 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// Display Name: Default Estimate Class 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="DefaultEstimateClass", EmitDefaultValue=false)]
		public StringValue? DefaultEstimateClass { get; set; }

		/// <summary>
		/// DAC Field Name: DefaultOrderType 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// Display Name: Default Prod. Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="DefaultProdOrderType", EmitDefaultValue=false)]
		public StringValue? DefaultProdOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: DefaultRevisionID 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// Display Name: Default Revision 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="DefaultRevision", EmitDefaultValue=false)]
		public StringValue? DefaultRevision { get; set; }

		/// <summary>
		/// DAC Field Name: DefaultWorkCenterID 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// Display Name: Default Work Center 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="DefaultWorkCenter", EmitDefaultValue=false)]
		public StringValue? DefaultWorkCenter { get; set; }

		/// <summary>
		/// DAC Field Name: EstimateNumberingID 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// Display Name: Estimate Number Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="EstimateNumberSequence", EmitDefaultValue=false)]
		public StringValue? EstimateNumberSequence { get; set; }

		/// <summary>
		/// During new revision of an estimate, should the new revision automatically be marked as the primary revision
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// Display Name: New Revision Is Primary 
		/// </summary>
		[DataMember(Name="NewRevisionIsPrimary", EmitDefaultValue=false)]
		public BooleanValue? NewRevisionIsPrimary { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// Display Name: Update All Revisions 
		/// </summary>
		[DataMember(Name="UpdateAllRevisions", EmitDefaultValue=false)]
		public BooleanValue? UpdateAllRevisions { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// Display Name: Update Price Info 
		/// </summary>
		[DataMember(Name="UpdatePriceInfo", EmitDefaultValue=false)]
		public BooleanValue? UpdatePriceInfo { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}