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
	/// Corresponds to the screen AM203500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ConfigurationFeature : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActiveFlg 
		/// DAC: PX.Objects.AM.AMFeature 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AllowNonInventoryOptions 
		/// DAC: PX.Objects.AM.AMFeature 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AllowNonInventoryOptions", EmitDefaultValue=false)]
		public BooleanValue? AllowNonInventoryOptions { get; set; }

		[DataMember(Name="ConfigurationFeatureAttribute", EmitDefaultValue=false)]
		public List<FeatureAttributes>? ConfigurationFeatureAttribute { get; set; }

		[DataMember(Name="ConfigurationFeatureOption", EmitDefaultValue=false)]
		public List<FeatureOptions>? ConfigurationFeatureOption { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMFeature 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DisplayOptionAttributes 
		/// DAC: PX.Objects.AM.AMFeature 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DisplayOptionAttributes", EmitDefaultValue=false)]
		public BooleanValue? DisplayOptionAttributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FeatureID 
		/// DAC: PX.Objects.AM.AMFeature 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FeatureID", EmitDefaultValue=false)]
		public StringValue? FeatureID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PrintResults 
		/// DAC: PX.Objects.AM.AMFeature 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PrintResults", EmitDefaultValue=false)]
		public BooleanValue? PrintResults { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}