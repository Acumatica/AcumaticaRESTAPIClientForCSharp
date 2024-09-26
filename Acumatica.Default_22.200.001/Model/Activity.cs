using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CR306010 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Activity : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Body 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Body", EmitDefaultValue=false)]
		public StringValue? Body { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsPrivate 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Internal", EmitDefaultValue=false)]
		public BooleanValue? Internal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NoteID 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Subject 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue? Summary { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ParentNoteID 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Task", EmitDefaultValue=false)]
		public StringValue? Task { get; set; }

		[DataMember(Name="TimeActivity", EmitDefaultValue=false)]
		public TimeActivity? TimeActivity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Type 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

		[DataMember(Name="CreatedByID", EmitDefaultValue=false)]
		public StringValue? CreatedByID { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNoteIDType 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RelatedEntityType", EmitDefaultValue=false)]
		public StringValue? RelatedEntityType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNoteID 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RelatedEntityNoteID", EmitDefaultValue=false)]
		public GuidValue? RelatedEntityNoteID { get; set; }

		[DataMember(Name="RelatedEntityDescription", EmitDefaultValue=false)]
		public StringValue? RelatedEntityDescription { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}