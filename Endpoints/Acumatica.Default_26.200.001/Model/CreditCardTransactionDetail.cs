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
	public class CreditCardTransactionDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: PCTranNumber</para>
		/// <para>DAC: PX.Objects.AR.CCProcTran</para>
		/// <para>Display Name: Proc. Center Tran. Nbr.</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="TranNbr", EmitDefaultValue=false)]
		public StringValue? TranNbr { get; set; }

		[DataMember(Name="TranApiNbr", EmitDefaultValue=false)]
		public StringValue? TranApiNbr { get; set; }

		[DataMember(Name="CommerceTranNbr", EmitDefaultValue=false)]
		public StringValue? CommerceTranNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CCProcTran</para>
		/// <para>Display Name: Tran. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="TranType", EmitDefaultValue=false)]
		public StringValue? TranType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AuthNumber</para>
		/// <para>DAC: PX.Objects.AR.CCProcTran</para>
		/// <para>Display Name: Proc. Center Auth. Nbr.</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="AuthNbr", EmitDefaultValue=false)]
		public StringValue? AuthNbr { get; set; }

		[DataMember(Name="TranDate", EmitDefaultValue=false)]
		public DateTimeValue? TranDate { get; set; }

		[DataMember(Name="ExtProfileId", EmitDefaultValue=false)]
		public StringValue? ExtProfileId { get; set; }

		[DataMember(Name="NeedValidation", EmitDefaultValue=false)]
		public BooleanValue? NeedValidation { get; set; }

		[DataMember(Name="OrigTranNbr", EmitDefaultValue=false)]
		public StringValue? OrigTranNbr { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

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