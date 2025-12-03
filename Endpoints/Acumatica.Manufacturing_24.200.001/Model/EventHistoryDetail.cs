using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class EventHistoryDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: RefBatNbr</para>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>Display Name: Batch Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC Field Name: CreatedDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>Display Name: Created At</para>
		/// </summary>
		[DataMember(Name="CreatedAt", EmitDefaultValue=false)]
		public DateTimeValue? CreatedAt { get; set; }

		/// <summary>
		/// The ID of the user who created the record.
		/// <para>DAC Field Name: CreatedByID</para>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>Display Name: Created By</para>
		/// </summary>
		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue? CreatedBy { get; set; }

		[DataMember(Name="CreatedScreen", EmitDefaultValue=false)]
		public StringValue? CreatedScreen { get; set; }

		/// <summary>
		/// The ID of the form that was used for the creation of the record.
		/// <para>DAC Field Name: CreatedByScreenID</para>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>Display Name: Created Screen ID</para>
		/// <para>SQL Type: char(8)</para>
		/// </summary>
		[DataMember(Name="CreatedScreenID", EmitDefaultValue=false)]
		public StringValue? CreatedScreenID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefDocType</para>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>Display Name: Doc Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LineNbr</para>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// <para>Display Name: Event Line Number</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="EventLineNumber", EmitDefaultValue=false)]
		public IntValue? EventLineNumber { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public GuidValue? RelatedDocument { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EventType</para>
		/// <para>DAC: PX.Objects.AM.AMProdEvnt</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}