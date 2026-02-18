using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CS207600</c> in the Acumatica ERP
	/// <para>Key Fields: BoxID</para>
	/// </summary>
	public class ShippingBox : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// <para>Display Name: Active by Default</para>
		/// </summary>
		public BooleanValue? ActiveByDefault { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// <para>Display Name: Box ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? BoxID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// <para>Display Name: Box Weight</para>
		/// </summary>
		public DecimalValue? BoxWeight { get; set; }

		public StringValue? CarriersPackage { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// </summary>
		public DecimalValue? Height { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// </summary>
		public DecimalValue? Length { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// <para>Display Name: Max Volume</para>
		/// </summary>
		public DecimalValue? MaxVolume { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// <para>Display Name: Max. Weight</para>
		/// </summary>
		public DecimalValue? MaxWeight { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CommonSetup__VolumeUOM</para>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// </summary>
		public StringValue? VolumeUOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CommonSetup__WeightUOM</para>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// </summary>
		public StringValue? WeightUOM { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// </summary>
		public DecimalValue? Width { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CommonSetup__LinearUOM</para>
		/// <para>DAC: PX.Objects.CS.CSBox</para>
		/// </summary>
		public StringValue? LinearUOM { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}