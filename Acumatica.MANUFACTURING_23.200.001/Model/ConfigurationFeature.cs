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
	/// Corresponds to the screen AM203500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ConfigurationFeature : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: ActiveFlg 
		/// DAC: PX.Objects.AM.AMFeature 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeature 
		/// Display Name: Allow Non-Inventory Options 
		/// </summary>
		[DataMember(Name="AllowNonInventoryOptions", EmitDefaultValue=false)]
		public BooleanValue? AllowNonInventoryOptions { get; set; }

		[DataMember(Name="ConfigurationFeatureAttribute", EmitDefaultValue=false)]
		public List<FeatureAttributes>? ConfigurationFeatureAttribute { get; set; }

		[DataMember(Name="ConfigurationFeatureOption", EmitDefaultValue=false)]
		public List<FeatureOptions>? ConfigurationFeatureOption { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMFeature 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeature 
		/// Display Name: Display Option Attributes 
		/// </summary>
		[DataMember(Name="DisplayOptionAttributes", EmitDefaultValue=false)]
		public BooleanValue? DisplayOptionAttributes { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeature 
		/// Display Name: Feature ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="FeatureID", EmitDefaultValue=false)]
		public StringValue? FeatureID { get; set; }

		/// <summary>
		/// Flag used for reporting
		/// DAC: PX.Objects.AM.AMFeature 
		/// Display Name: Print Results 
		/// </summary>
		[DataMember(Name="PrintResults", EmitDefaultValue=false)]
		public BooleanValue? PrintResults { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}