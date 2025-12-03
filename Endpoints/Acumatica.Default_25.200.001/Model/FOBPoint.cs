using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CS208500</c> in the Acumatica ERP
	/// <para>Key Fields: FOBPointID</para>
	/// </summary>
	[DataContract]
	public class FOBPoint : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The description of the FOB Point.
		/// <para>DAC: PX.Objects.CS.FOBPoint</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The unique identifier of the FOB Point.
		/// <para>DAC: PX.Objects.CS.FOBPoint</para>
		/// <para>Display Name: FOB Point ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="FOBPointID", EmitDefaultValue=false)]
		public StringValue? FOBPointID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}