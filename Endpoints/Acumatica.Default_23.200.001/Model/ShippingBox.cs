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
	/// Corresponds to the screen <c>CS207600</c> in the Acumatica ERP
	/// <para>Key Fields: BoxID</para>
	/// </summary>
	[DataContract]
	public class ShippingBox : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// <para>Display Name: Active by Default</para>
		/// </summary>
		[DataMember(Name="ActiveByDefault", EmitDefaultValue=false)]
		public BooleanValue? ActiveByDefault { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// <para>Display Name: Box ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="BoxID", EmitDefaultValue=false)]
		public StringValue? BoxID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// <para>Display Name: Box Weight</para>
		/// </summary>
		[DataMember(Name="BoxWeight", EmitDefaultValue=false)]
		public DecimalValue? BoxWeight { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CarrierBox</para>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// </summary>
		[DataMember(Name="CarriersPackage", EmitDefaultValue=false)]
		public StringValue? CarriersPackage { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// </summary>
		[DataMember(Name="Height", EmitDefaultValue=false)]
		public DecimalValue? Height { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// </summary>
		[DataMember(Name="Length", EmitDefaultValue=false)]
		public DecimalValue? Length { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// <para>Display Name: Max Volume</para>
		/// </summary>
		[DataMember(Name="MaxVolume", EmitDefaultValue=false)]
		public DecimalValue? MaxVolume { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// <para>Display Name: Max. Weight</para>
		/// </summary>
		[DataMember(Name="MaxWeight", EmitDefaultValue=false)]
		public DecimalValue? MaxWeight { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CommonSetup__VolumeUOM</para>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// </summary>
		[DataMember(Name="VolumeUOM", EmitDefaultValue=false)]
		public StringValue? VolumeUOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CommonSetup__WeightUOM</para>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// </summary>
		[DataMember(Name="WeightUOM", EmitDefaultValue=false)]
		public StringValue? WeightUOM { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// </summary>
		[DataMember(Name="Width", EmitDefaultValue=false)]
		public DecimalValue? Width { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CommonSetup__LinearUOM</para>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// </summary>
		[DataMember(Name="LinearUOM", EmitDefaultValue=false)]
		public StringValue? LinearUOM { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}