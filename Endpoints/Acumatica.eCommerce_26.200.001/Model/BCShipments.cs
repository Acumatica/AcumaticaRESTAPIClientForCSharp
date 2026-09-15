using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>BC408030</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class BCShipments : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		[DataMember(Name="LastModified", EmitDefaultValue=false)]
		public DateTimeValue? LastModified { get; set; }

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		[DataMember(Name="ShippingNoteID", EmitDefaultValue=false)]
		public GuidValue? ShippingNoteID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		[DataMember(Name="BindingID", EmitDefaultValue=false)]
		public IntValue? BindingID { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<BCShipmentsResult>? Results { get; set; }

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
			public const string Translations = "Translations";
			public const string Results = "Results";

			//Intentionally excluded
			//public const string All = "Files,Translations,Results";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/26.200.001";
		}
	}
}