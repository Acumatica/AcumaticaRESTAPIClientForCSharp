using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>BC408030</c> in the Acumatica ERP
	/// </summary>
	public class BCShipments : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		public DateTimeValue? LastModified { get; set; }

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		public GuidValue? ShippingNoteID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		public IntValue? BindingID { get; set; }

		public List<BCShipmentsResult>? Results { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Results = "Results";
			public const string Results_Files = "Results/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Results,Results/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/23.200.001";
		}
	}
}