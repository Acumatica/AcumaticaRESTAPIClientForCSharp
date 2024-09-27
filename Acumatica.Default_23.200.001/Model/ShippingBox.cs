using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CS207600 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ShippingBox : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.CS.CSBox 
		/// Display Name: Active by Default 
		/// </summary>
		[DataMember(Name="ActiveByDefault", EmitDefaultValue=false)]
		public BooleanValue? ActiveByDefault { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSBox 
		/// Display Name: Box ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BoxID", EmitDefaultValue=false)]
		public StringValue? BoxID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSBox 
		/// Display Name: Box Weight 
		/// </summary>
		[DataMember(Name="BoxWeight", EmitDefaultValue=false)]
		public DecimalValue? BoxWeight { get; set; }

		/// <summary>
		/// DAC Field Name: CarrierBox 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		[DataMember(Name="CarriersPackage", EmitDefaultValue=false)]
		public StringValue? CarriersPackage { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSBox 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		[DataMember(Name="Height", EmitDefaultValue=false)]
		public DecimalValue? Height { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		[DataMember(Name="Length", EmitDefaultValue=false)]
		public DecimalValue? Length { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSBox 
		/// Display Name: Max Volume 
		/// </summary>
		[DataMember(Name="MaxVolume", EmitDefaultValue=false)]
		public DecimalValue? MaxVolume { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSBox 
		/// Display Name: Max. Weight 
		/// </summary>
		[DataMember(Name="MaxWeight", EmitDefaultValue=false)]
		public DecimalValue? MaxWeight { get; set; }

		/// <summary>
		/// DAC Field Name: CommonSetup__VolumeUOM 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		[DataMember(Name="VolumeUOM", EmitDefaultValue=false)]
		public StringValue? VolumeUOM { get; set; }

		/// <summary>
		/// DAC Field Name: CommonSetup__WeightUOM 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		[DataMember(Name="WeightUOM", EmitDefaultValue=false)]
		public StringValue? WeightUOM { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		[DataMember(Name="Width", EmitDefaultValue=false)]
		public DecimalValue? Width { get; set; }

		/// <summary>
		/// DAC Field Name: CommonSetup__LinearUOM 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		[DataMember(Name="LinearUOM", EmitDefaultValue=false)]
		public StringValue? LinearUOM { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}