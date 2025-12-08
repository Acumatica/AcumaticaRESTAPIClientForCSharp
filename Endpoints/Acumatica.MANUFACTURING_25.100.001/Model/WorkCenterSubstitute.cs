using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	[DataContract]
	public class WorkCenterSubstitute : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: SubstituteWcID</para>
		/// <para>DAC: PX.Objects.AM.AMWCSubstitute</para>
		/// <para>Display Name: Substitute Work Center</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="SubstituteWorkCenter", EmitDefaultValue=false)]
		public StringValue? SubstituteWorkCenter { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UpdateOperDesc</para>
		/// <para>DAC: PX.Objects.AM.AMWCSubstitute</para>
		/// <para>Display Name: Update Operation Description</para>
		/// </summary>
		[DataMember(Name="UpdateOperationDescription", EmitDefaultValue=false)]
		public BooleanValue? UpdateOperationDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMWC</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}