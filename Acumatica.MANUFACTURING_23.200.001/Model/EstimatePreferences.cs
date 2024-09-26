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
		/// 
		/// Display Name:
		/// DAC Field Name: AutoNumberRevisionID 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AutoNumberRevisions", EmitDefaultValue=false)]
		public BooleanValue? AutoNumberRevisions { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultEstimateClassID 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultEstimateClass", EmitDefaultValue=false)]
		public StringValue? DefaultEstimateClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultOrderType 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultProdOrderType", EmitDefaultValue=false)]
		public StringValue? DefaultProdOrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultRevisionID 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultRevision", EmitDefaultValue=false)]
		public StringValue? DefaultRevision { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultWorkCenterID 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultWorkCenter", EmitDefaultValue=false)]
		public StringValue? DefaultWorkCenter { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EstimateNumberingID 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EstimateNumberSequence", EmitDefaultValue=false)]
		public StringValue? EstimateNumberSequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NewRevisionIsPrimary 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NewRevisionIsPrimary", EmitDefaultValue=false)]
		public BooleanValue? NewRevisionIsPrimary { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UpdateAllRevisions 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UpdateAllRevisions", EmitDefaultValue=false)]
		public BooleanValue? UpdateAllRevisions { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UpdatePriceInfo 
		/// DAC: PX.Objects.AM.AMEstimateSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UpdatePriceInfo", EmitDefaultValue=false)]
		public BooleanValue? UpdatePriceInfo { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}