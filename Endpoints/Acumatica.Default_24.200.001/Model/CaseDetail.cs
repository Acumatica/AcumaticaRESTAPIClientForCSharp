using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class CaseDetail : Entity
	{

		/// <summary>
		/// The unique identifier assigned to the case in accordance with the numbering sequence assigned to cases on the Customer Management Preferences (CR101000) form.
		/// <para>DAC Field Name: CaseCD</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Case ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? CaseID { get; set; }

		/// <summary>
		/// The identifier of the case class.
		/// <para>DAC Field Name: CaseClassID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Case Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// The date and time when the case was closed. The field is filled in by the system.
		/// <para>DAC Field Name: ResolutionDate</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Closed On</para>
		/// </summary>
		public DateTimeValue? ClosingDate { get; set; }

		/// <summary>
		/// Date and time of the case creation.
		/// <para>DAC Field Name: ReportedOnDateTime</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Reported On</para>
		/// </summary>
		public DateTimeValue? DateReported { get; set; }

		/// <summary>
		/// The estimation of the time (in minutes) required for the case resolution.
		/// <para>DAC Field Name: TimeEstimated</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		public StringValue? Estimation { get; set; }

		public StringValue? InitialResponse { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		/// <summary>
		/// The reason why the case has been changed to the current status.
		/// <para>DAC Field Name: Resolution</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Reason { get; set; }

		/// <summary>
		/// The severity level of the case.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Severity { get; set; }

		/// <summary>
		/// The status of the contact.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// The subject or description of the opportunity.
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Subject { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// <para>DAC Field Name: WorkgroupID</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// </summary>
		public StringValue? Workgroup { get; set; }

	}
}