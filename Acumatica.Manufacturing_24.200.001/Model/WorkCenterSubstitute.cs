using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class WorkCenterSubstitute : Entity
	{

		/// <summary>
		/// DAC Field Name: SubstituteWcID 
		/// DAC: PX.Objects.AM.AMWCSubstitute 
		/// Display Name: Substitute Work Center 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="SubstituteWorkCenter", EmitDefaultValue=false)]
		public StringValue? SubstituteWorkCenter { get; set; }

		/// <summary>
		/// DAC Field Name: UpdateOperDesc 
		/// DAC: PX.Objects.AM.AMWCSubstitute 
		/// Display Name: Update Operation Description 
		/// </summary>
		[DataMember(Name="UpdateOperationDescription", EmitDefaultValue=false)]
		public BooleanValue? UpdateOperationDescription { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMWC 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}