using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM401500</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProductionAttributes : Entity, ITopLevelEntity
	{

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<ProductionAttributesDetail>? Detail { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShowOrderAttributes</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributesFilter</para>
		/// <para>Display Name: Order Attributes</para>
		/// </summary>
		[DataMember(Name="OrderAttributes", EmitDefaultValue=false)]
		public BooleanValue? OrderAttributes { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributesFilter</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributesFilter</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShowTransactionAttributes</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributesFilter</para>
		/// <para>Display Name: Transaction Attributes</para>
		/// </summary>
		[DataMember(Name="TransactionAttributes", EmitDefaultValue=false)]
		public BooleanValue? TransactionAttributes { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Detail = "Detail";
			public const string Detail_Files = "Detail/Files";

			//Intentionally excluded
			//public const string All = "Files,Detail,Detail/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}