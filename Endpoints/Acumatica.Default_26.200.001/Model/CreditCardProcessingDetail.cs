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
	public class CreditCardProcessingDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Amount</para>
		/// <para>DAC: PX.Objects.AR.CCProcTran</para>
		/// <para>Display Name: Tran. Amount</para>
		/// </summary>
		[DataMember(Name="TransactionAmount", EmitDefaultValue=false)]
		public DecimalValue? TransactionAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranStatus</para>
		/// <para>DAC: PX.Objects.AR.CCProcTran</para>
		/// <para>Display Name: Tran. Status</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="TransactionStatus", EmitDefaultValue=false)]
		public StringSingleSelectValue? TransactionStatus { get; set; }

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