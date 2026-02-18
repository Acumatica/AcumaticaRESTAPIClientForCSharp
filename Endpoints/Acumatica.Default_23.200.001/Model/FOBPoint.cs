using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CS208500</c> in the Acumatica ERP
	/// <para>Key Fields: FOBPointID</para>
	/// </summary>
	public class FOBPoint : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The description of the FOB Point.
		/// <para>DAC: PX.Objects.CS.FOBPoint</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The unique identifier of the FOB Point.
		/// <para>DAC: PX.Objects.CS.FOBPoint</para>
		/// <para>Display Name: FOB Point ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? FOBPointID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}