using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class CaseRelatedCase : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: ChildCaseCD</para>
		/// <para>DAC: PX.Objects.CR.CRCaseReference</para>
		/// <para>Display Name: Case ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="CaseID", EmitDefaultValue=false)]
		public StringValue? CaseID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CRCaseRelated__OwnerID</para>
		/// <para>DAC: PX.Objects.CR.CRCaseReference</para>
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		[DataMember(Name="ParentCaseID", EmitDefaultValue=false)]
		public StringValue? ParentCaseID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRCaseReference</para>
		/// <para>Display Name: Relation Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="RelationType", EmitDefaultValue=false)]
		public StringValue? RelationType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CRCaseRelated__Status</para>
		/// <para>DAC: PX.Objects.CR.CRCaseReference</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CRCaseRelated__Subject</para>
		/// <para>DAC: PX.Objects.CR.CRCaseReference</para>
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CRCaseRelated__WorkgroupID</para>
		/// <para>DAC: PX.Objects.CR.CRCaseReference</para>
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

	}
}