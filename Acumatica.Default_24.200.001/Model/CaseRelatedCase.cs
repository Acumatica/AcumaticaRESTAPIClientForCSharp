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
		/// DAC Field Name: ChildCaseCD 
		/// DAC: PX.Objects.CR.CRCaseReference 
		/// Display Name: Case ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="CaseID", EmitDefaultValue=false)]
		public StringValue? CaseID { get; set; }

		/// <summary>
		/// DAC Field Name: CRCaseRelated__OwnerID 
		/// DAC: PX.Objects.CR.CRCaseReference 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		[DataMember(Name="ParentCaseID", EmitDefaultValue=false)]
		public StringValue? ParentCaseID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRCaseReference 
		/// Display Name: Relation Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="RelationType", EmitDefaultValue=false)]
		public StringValue? RelationType { get; set; }

		/// <summary>
		/// DAC Field Name: CRCaseRelated__Status 
		/// DAC: PX.Objects.CR.CRCaseReference 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: CRCaseRelated__Subject 
		/// DAC: PX.Objects.CR.CRCaseReference 
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		/// <summary>
		/// DAC Field Name: CRCaseRelated__WorkgroupID 
		/// DAC: PX.Objects.CR.CRCaseReference 
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

	}
}