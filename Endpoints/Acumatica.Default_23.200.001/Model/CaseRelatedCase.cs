using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class CaseRelatedCase : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: ChildCaseCD</para>
		/// <para>DAC: PX.Objects.CR.CRCaseReference</para>
		/// <para>Display Name: Case ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? CaseID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CRCaseRelated__OwnerID</para>
		/// <para>DAC: PX.Objects.CR.CRCaseReference</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		public StringValue? ParentCaseID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRCaseReference</para>
		/// <para>Display Name: Relation Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? RelationType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CRCaseRelated__Status</para>
		/// <para>DAC: PX.Objects.CR.CRCaseReference</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CRCaseRelated__Subject</para>
		/// <para>DAC: PX.Objects.CR.CRCaseReference</para>
		/// </summary>
		public StringValue? Subject { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CRCaseRelated__WorkgroupID</para>
		/// <para>DAC: PX.Objects.CR.CRCaseReference</para>
		/// </summary>
		public StringValue? Workgroup { get; set; }

	}
}