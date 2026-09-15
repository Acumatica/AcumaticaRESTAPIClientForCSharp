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
	public class PaymentMethodProcessingCenterDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Objects.CA.CCProcessingCenterPmntMethod</para>
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentMethodID</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name:  Payment Method ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProcessingCenterID</para>
		/// <para>DAC: PX.Objects.CA.CCProcessingCenterPmntMethod</para>
		/// <para>Display Name: Proc. Center ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ProcCenterID", EmitDefaultValue=false)]
		public StringValue? ProcCenterID { get; set; }

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