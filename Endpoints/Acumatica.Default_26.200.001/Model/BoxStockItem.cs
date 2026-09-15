using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class BoxStockItem : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemBoxEx</para>
		/// <para>Display Name: Box ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="BoxID", EmitDefaultValue=false)]
		public StringValue? BoxID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemBoxEx</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Max Qty.</para>
		/// </summary>
		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public DecimalValue? MaxQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemBoxEx</para>
		/// <para>Display Name: Max Volume</para>
		/// </summary>
		[DataMember(Name="MaxVolume", EmitDefaultValue=false)]
		public DecimalValue? MaxVolume { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemBoxEx</para>
		/// <para>Display Name: Max. Weight</para>
		/// </summary>
		[DataMember(Name="MaxWeight", EmitDefaultValue=false)]
		public DecimalValue? MaxWeight { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INComponent</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INComponent</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}