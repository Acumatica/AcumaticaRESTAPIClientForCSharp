using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class BusinessAccountCaseDetail : Entity
	{

		/// <summary>
		/// The unique identifier assigned to the case in accordance with the numbering sequence assigned to cases on the Customer Management Preferences (CR101000) form.
		/// <para>DAC Field Name: CaseCD</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Case ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="CaseID", EmitDefaultValue=false)]
		public StringValue? CaseID { get; set; }

		/// <summary>
		/// The identifier of the case class.
		/// <para>DAC Field Name: CaseClassID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Case Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// The date and time when the case was closed. The field is filled in by the system.
		/// <para>DAC Field Name: ResolutionDate</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Closed On</para>
		/// </summary>
		[DataMember(Name="ClosingDate", EmitDefaultValue=false)]
		public DateTimeValue? ClosingDate { get; set; }

		/// <summary>
		/// The contract associated with the case.
		/// <para>DAC Field Name: ContractID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		[DataMember(Name="Contract", EmitDefaultValue=false)]
		public StringValue? Contract { get; set; }

		/// <summary>
		/// Date and time of the case creation.
		/// <para>DAC Field Name: ReportedOnDateTime</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Reported On</para>
		/// </summary>
		[DataMember(Name="DateReported", EmitDefaultValue=false)]
		public DateTimeValue? DateReported { get; set; }

		/// <summary>
		/// The estimation of the time (in minutes) required for the case resolution.
		/// <para>DAC Field Name: TimeEstimated</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		[DataMember(Name="Estimation", EmitDefaultValue=false)]
		public StringValue? Estimation { get; set; }

		[DataMember(Name="InitialResponse", EmitDefaultValue=false)]
		public StringValue? InitialResponse { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// The reason why the Status of this contact has been changed.
		/// <para>DAC Field Name: Resolution</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue? Reason { get; set; }

		/// <summary>
		/// The severity level of the case.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Severity", EmitDefaultValue=false)]
		public StringValue? Severity { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Customer Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The subject or description of the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// <para>DAC Field Name: WorkgroupID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

	}
}