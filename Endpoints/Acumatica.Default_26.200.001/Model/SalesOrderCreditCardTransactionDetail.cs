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
	public class SalesOrderCreditCardTransactionDetail : Entity
	{

		[DataMember(Name="AuthNbr", EmitDefaultValue=false)]
		public StringValue? AuthNbr { get; set; }

		[DataMember(Name="ExtProfileId", EmitDefaultValue=false)]
		public StringValue? ExtProfileId { get; set; }

		[DataMember(Name="NeedValidation", EmitDefaultValue=false)]
		public BooleanValue? NeedValidation { get; set; }

		[DataMember(Name="TranDate", EmitDefaultValue=false)]
		public DateTimeValue? TranDate { get; set; }

		[DataMember(Name="TranNbr", EmitDefaultValue=false)]
		public StringValue? TranNbr { get; set; }

		[DataMember(Name="TranType", EmitDefaultValue=false)]
		public StringSingleSelectValue? TranType { get; set; }

		[DataMember(Name="CardType", EmitDefaultValue=false)]
		public StringValue? CardType { get; set; }

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