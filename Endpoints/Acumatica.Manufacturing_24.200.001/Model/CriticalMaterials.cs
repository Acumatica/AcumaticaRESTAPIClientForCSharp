using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM401000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CriticalMaterials : Entity, ITopLevelEntity
	{

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<CriticalMaterialDetail>? Detail { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProdItemFilter</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.ProdItemFilter</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShowAll</para>
		/// <para>DAC: PX.Objects.AM.ProdItemFilter</para>
		/// <para>Display Name: Show All Items</para>
		/// </summary>
		[DataMember(Name="ShowAllItems", EmitDefaultValue=false)]
		public BooleanValue? ShowAllItems { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProdItemFilter</para>
		/// <para>Display Name: Show Allocated</para>
		/// </summary>
		[DataMember(Name="ShowAllocated", EmitDefaultValue=false)]
		public BooleanValue? ShowAllocated { get; set; }

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
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}