using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	[DataContract]
	public class WorkCenterSubstitute : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: SubstituteWcID</para>
		/// <para>DAC: PX.Objects.AM.AMWCSubstitute</para>
		/// <para>Display Name: Substitute Work Center</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="SubstituteWorkCenter", EmitDefaultValue=false)]
		public StringValue? SubstituteWorkCenter { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UpdateOperDesc</para>
		/// <para>DAC: PX.Objects.AM.AMWCSubstitute</para>
		/// <para>Display Name: Update Operation Description</para>
		/// </summary>
		[DataMember(Name="UpdateOperationDescription", EmitDefaultValue=false)]
		public BooleanValue? UpdateOperationDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

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