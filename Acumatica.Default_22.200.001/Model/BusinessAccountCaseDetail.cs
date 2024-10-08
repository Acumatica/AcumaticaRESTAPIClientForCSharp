using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class BusinessAccountCaseDetail : Entity
	{

		/// <summary>
		/// The unique identifier assigned to the case in accordance with the numbering sequence assigned to cases on the Customer Management Preferences (CR101000) form.
		/// DAC Field Name: CaseCD 
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Case ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="CaseID", EmitDefaultValue=false)]
		public StringValue? CaseID { get; set; }

		/// <summary>
		/// The identifier of the case class.
		/// DAC Field Name: CaseClassID 
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Case Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// The date and time when the case was closed. The field is filled in by the system.
		/// DAC Field Name: ResolutionDate 
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Closed On 
		/// </summary>
		[DataMember(Name="ClosingDate", EmitDefaultValue=false)]
		public DateTimeValue? ClosingDate { get; set; }

		/// <summary>
		/// The contract associated with the case.
		/// DAC Field Name: ContractID 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		[DataMember(Name="Contract", EmitDefaultValue=false)]
		public StringValue? Contract { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Created On 
		/// </summary>
		[DataMember(Name="DateReported", EmitDefaultValue=false)]
		public DateTimeValue? DateReported { get; set; }

		/// <summary>
		/// The estimation of the time (in minutes) required for the case resolution.
		/// DAC Field Name: TimeEstimated 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		[DataMember(Name="Estimation", EmitDefaultValue=false)]
		public StringValue? Estimation { get; set; }

		[DataMember(Name="InitialResponse", EmitDefaultValue=false)]
		public StringValue? InitialResponse { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// The reason why the Status of this contact has been changed.
		/// DAC Field Name: Resolution 
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue? Reason { get; set; }

		/// <summary>
		/// The severity level of the case.
		/// DAC: PX.Objects.CR.CRCase 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Severity", EmitDefaultValue=false)]
		public StringValue? Severity { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Customer Status 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The subject or description of the opportunity.
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Description 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

	}
}