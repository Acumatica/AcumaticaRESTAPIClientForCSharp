using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM401500</c> in the Acumatica ERP
	/// </summary>
	public class ProductionAttributes : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributesFilter</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributesFilter</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShowTransactionAttributes</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributesFilter</para>
		/// <para>Display Name: Transaction Attributes</para>
		/// </summary>
		public BooleanValue? TransactionAttributes { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShowOrderAttributes</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributesFilter</para>
		/// <para>Display Name: Order Attributes</para>
		/// </summary>
		public BooleanValue? OrderAttributes { get; set; }

		#endregion

		#region Details
		public List<ProductionAttributesDetail>? Detail { get; set; }

		#endregion

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
			public const string Translations = "Translations";
			public const string Detail = "Detail";

			//Intentionally excluded
			//public const string All = "Files,Translations,Detail";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}