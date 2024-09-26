using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CS207600 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ShippingBox : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActiveByDefault 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ActiveByDefault", EmitDefaultValue=false)]
		public BooleanValue? ActiveByDefault { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BoxID 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BoxID", EmitDefaultValue=false)]
		public StringValue? BoxID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BoxWeight 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BoxWeight", EmitDefaultValue=false)]
		public DecimalValue? BoxWeight { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CarrierBox 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CarriersPackage", EmitDefaultValue=false)]
		public StringValue? CarriersPackage { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Height 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Height", EmitDefaultValue=false)]
		public DecimalValue? Height { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Length 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Length", EmitDefaultValue=false)]
		public DecimalValue? Length { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MaxVolume 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MaxVolume", EmitDefaultValue=false)]
		public DecimalValue? MaxVolume { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MaxWeight 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MaxWeight", EmitDefaultValue=false)]
		public DecimalValue? MaxWeight { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CommonSetup__VolumeUOM 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VolumeUOM", EmitDefaultValue=false)]
		public StringValue? VolumeUOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CommonSetup__WeightUOM 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WeightUOM", EmitDefaultValue=false)]
		public StringValue? WeightUOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Width 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Width", EmitDefaultValue=false)]
		public DecimalValue? Width { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CommonSetup__LinearUOM 
		/// DAC: PX.Objects.CS.CSBox 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LinearUOM", EmitDefaultValue=false)]
		public StringValue? LinearUOM { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}