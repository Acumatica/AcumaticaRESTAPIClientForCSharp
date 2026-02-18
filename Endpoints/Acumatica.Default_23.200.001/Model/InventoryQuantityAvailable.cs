using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GI640590</c> in the Acumatica ERP
	/// </summary>
	public class InventoryQuantityAvailable : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: InventoryItem</para>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		public List<InventoryQuantityAvailableDetail>? Results { get; set; }

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		public DateTimeValue? LastModifiedDateTime { get; set; }

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
			return "entity/Default/23.200.001";
		}
	}
}