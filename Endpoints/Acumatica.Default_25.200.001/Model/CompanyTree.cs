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
	public class CompanyTree : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.CR.ContactNotification 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Specifies whether the member is the owner of the workgroup.
		/// DAC Field Name: IsOwner 
		/// DAC: PX.TM.EPCompanyTreeMember 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public BooleanValue? Owner { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// DAC: PX.Objects.CR.CRPMTimeActivity 
		/// Display Name: Workgroup 
		/// </summary>
		[DataMember(Name="WorkgroupID", EmitDefaultValue=false)]
		public StringValue? WorkgroupID { get; set; }

	}
}