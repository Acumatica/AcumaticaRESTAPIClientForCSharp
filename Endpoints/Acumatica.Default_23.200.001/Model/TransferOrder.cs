using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN304000</c> in the Acumatica ERP
	/// <para>Key Fields: ReferenceNbr</para>
	/// </summary>
	public class TransferOrder : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: TranDate</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// </summary>
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<TransferOrderDetail>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExtRefNbr</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: External Ref.</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		public StringValue? ExternalRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: Warehouse ID</para>
		/// </summary>
		public StringValue? FromWarehouseID { get; set; }

		public BooleanValue? Hold { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: Post Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: Total Qty.</para>
		/// </summary>
		public DecimalValue? TotalQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ToSiteID</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: To Warehouse ID</para>
		/// </summary>
		public StringValue? ToWarehouseID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: Transfer Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? TransferType { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";
			public const string Details_Allocations = "Details/Allocations";
			public const string Details_Allocations_Files = "Details/Allocations/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files,Details/Allocations,Details/Allocations/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}