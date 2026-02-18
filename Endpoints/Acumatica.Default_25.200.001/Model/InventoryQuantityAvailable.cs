using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SO640590</c> in the Acumatica ERP
	/// </summary>
	public class InventoryQuantityAvailable : Entity, ITopLevelEntity
	{

		public StringValue? InventoryID { get; set; }

		public List<InventoryQuantityAvailableDetail>? Results { get; set; }

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
			return "entity/Default/25.200.001";
		}
	}
}