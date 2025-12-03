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
	/// Corresponds to the screen <c>CS208000</c> in the Acumatica ERP
	/// <para>Key Fields: TermID</para>
	/// </summary>
	[DataContract]
	public class ShippingTerm : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CS.ShipTerms</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ShippingTermDetail>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipTermsID</para>
		/// <para>DAC: PX.Objects.CS.ShipTerms</para>
		/// <para>Display Name: Term ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="TermID", EmitDefaultValue=false)]
		public StringValue? TermID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";

			//Intentionally excluded
			//public const string All = "Files,Details,Details/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}