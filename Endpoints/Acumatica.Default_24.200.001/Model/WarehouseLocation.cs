using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class WarehouseLocation : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AssemblyValid</para>
		/// <para>DAC: PX.Objects.IN.INLocation</para>
		/// <para>Display Name: Assembly Allowed</para>
		/// </summary>
		public BooleanValue? AssemblyAllowed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationCD</para>
		/// <para>DAC: PX.Objects.IN.INLocation</para>
		/// <para>Display Name: Location ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INLocation</para>
		/// <para>Display Name: Pick Priority</para>
		/// </summary>
		public ShortValue? PickPriority { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReceiptsValid</para>
		/// <para>DAC: PX.Objects.IN.INLocation</para>
		/// <para>Display Name: Receipts Allowed</para>
		/// </summary>
		public BooleanValue? ReceiptsAllowed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesValid</para>
		/// <para>DAC: PX.Objects.IN.INLocation</para>
		/// <para>Display Name: Sales Allowed</para>
		/// </summary>
		public BooleanValue? SalesAllowed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TransfersValid</para>
		/// <para>DAC: PX.Objects.IN.INLocation</para>
		/// <para>Display Name: Transfers Allowed</para>
		/// </summary>
		public BooleanValue? TransfersAllowed { get; set; }

	}
}