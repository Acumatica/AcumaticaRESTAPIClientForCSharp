using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class EventHistoryDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: RefBatNbr</para>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>Display Name: Batch Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC Field Name: CreatedDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>Display Name: Created At</para>
		/// </summary>
		public DateTimeValue? CreatedAt { get; set; }

		/// <summary>
		/// The ID of the user who created the record.
		/// <para>DAC Field Name: CreatedByID</para>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>Display Name: Created By</para>
		/// </summary>
		public StringValue? CreatedBy { get; set; }

		public StringValue? CreatedScreen { get; set; }

		/// <summary>
		/// The ID of the form that was used for the creation of the record.
		/// <para>DAC Field Name: CreatedByScreenID</para>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>Display Name: Created Screen ID</para>
		/// <para>SQL Type: char(8)</para>
		/// </summary>
		public StringValue? CreatedScreenID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefDocType</para>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>Display Name: Doc Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? DocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LineNbr</para>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>Display Name: Event Line Number</para>
		/// Key Field
		/// </summary>
		public IntValue? EventLineNumber { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// Key Field
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		public GuidValue? RelatedDocument { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EventType</para>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// </summary>
		public StringValue? Type { get; set; }

	}
}