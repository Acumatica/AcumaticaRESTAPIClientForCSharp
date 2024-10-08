using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	[DataContract]
	public class FeatureAttributes : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureAttribute 
		/// Display Name: Attribute ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// DAC Field Name: Value 
		/// DAC: PX.Objects.AM.AMFeatureAttribute 
		/// Display Name: Default Value 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="DefaultValue", EmitDefaultValue=false)]
		public StringValue? DefaultValue { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMFeature 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureAttribute 
		/// </summary>
		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeature 
		/// Display Name: Feature ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="FeatureID", EmitDefaultValue=false)]
		public StringValue? FeatureID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureAttribute 
		/// Display Name: Is Formula 
		/// </summary>
		[DataMember(Name="IsFormula", EmitDefaultValue=false)]
		public BooleanValue? IsFormula { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureOption 
		/// Display Name: Line Nbr 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureAttribute 
		/// </summary>
		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue? Required { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureAttribute 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Variable", EmitDefaultValue=false)]
		public StringValue? Variable { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMFeatureAttribute 
		/// </summary>
		[DataMember(Name="Visible", EmitDefaultValue=false)]
		public BooleanValue? Visible { get; set; }

	}
}