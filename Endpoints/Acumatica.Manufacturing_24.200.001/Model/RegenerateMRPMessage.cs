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
	public class RegenerateMRPMessage : Entity
	{

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC Field Name: CreatedDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMRPAuditTable</para>
		/// <para>Display Name: Created At</para>
		/// </summary>
		[DataMember(Name="CreatedAt", EmitDefaultValue=false)]
		public DateTimeValue? CreatedAt { get; set; }

		/// <summary>
		/// The ID of the user who created the record.
		/// <para>DAC Field Name: CreatedByID</para>
		/// <para>DAC: PX.Objects.AM.AMRPAuditTable</para>
		/// <para>Display Name: Created By</para>
		/// </summary>
		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue? CreatedBy { get; set; }

		/// <summary>
		/// The ID of the form that was used for the creation of the record.
		/// <para>DAC Field Name: CreatedByScreenID</para>
		/// <para>DAC: PX.Objects.AM.AMRPAuditTable</para>
		/// <para>Display Name: Created Screen ID</para>
		/// <para>SQL Type: char(8)</para>
		/// </summary>
		[DataMember(Name="CreatedScreenID", EmitDefaultValue=false)]
		public StringValue? CreatedScreenID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MsgText</para>
		/// <para>DAC: PX.Objects.AM.AMRPAuditTable</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="Message", EmitDefaultValue=false)]
		public StringValue? Message { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MsgType</para>
		/// <para>DAC: PX.Objects.AM.AMRPAuditTable</para>
		/// <para>Display Name: Message Type</para>
		/// </summary>
		[DataMember(Name="MessageType", EmitDefaultValue=false)]
		public StringValue? MessageType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPAuditTable</para>
		/// <para>Display Name: Process ID</para>
		/// </summary>
		[DataMember(Name="ProcessID", EmitDefaultValue=false)]
		public GuidValue? ProcessID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPAuditTable</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Recno", EmitDefaultValue=false)]
		public IntValue? Recno { get; set; }

	}
}