using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class RegenerateMRPMessage : Entity
	{

		/// <summary>
		/// The date and time when the record was created.
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.AM.AMRPAuditTable 
		/// Display Name: Created At 
		/// </summary>
		[DataMember(Name="CreatedAt", EmitDefaultValue=false)]
		public DateTimeValue? CreatedAt { get; set; }

		/// <summary>
		/// The ID of the user who created the record.
		/// DAC Field Name: CreatedByID 
		/// DAC: PX.Objects.AM.AMRPAuditTable 
		/// Display Name: Created By 
		/// </summary>
		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue? CreatedBy { get; set; }

		/// <summary>
		/// The ID of the form that was used for the creation of the record.
		/// DAC Field Name: CreatedByScreenID 
		/// DAC: PX.Objects.AM.AMRPAuditTable 
		/// Display Name: Created Screen ID 
		/// SQL Type: char(8) 
		/// </summary>
		[DataMember(Name="CreatedScreenID", EmitDefaultValue=false)]
		public StringValue? CreatedScreenID { get; set; }

		/// <summary>
		/// DAC Field Name: MsgText 
		/// DAC: PX.Objects.AM.AMRPAuditTable 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Message", EmitDefaultValue=false)]
		public StringValue? Message { get; set; }

		/// <summary>
		/// DAC Field Name: MsgType 
		/// DAC: PX.Objects.AM.AMRPAuditTable 
		/// Display Name: Message Type 
		/// </summary>
		[DataMember(Name="MessageType", EmitDefaultValue=false)]
		public StringValue? MessageType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPAuditTable 
		/// Display Name: Process ID 
		/// </summary>
		[DataMember(Name="ProcessID", EmitDefaultValue=false)]
		public GuidValue? ProcessID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPAuditTable 
		/// Key Field
		/// </summary>
		[DataMember(Name="Recno", EmitDefaultValue=false)]
		public IntValue? Recno { get; set; }

	}
}