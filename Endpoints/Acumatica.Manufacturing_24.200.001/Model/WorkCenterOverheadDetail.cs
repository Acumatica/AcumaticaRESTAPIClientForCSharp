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
	public class WorkCenterOverheadDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: AMOverhead__Descr 
		/// DAC: PX.Objects.AM.AMWCOvhd 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: OFactor 
		/// DAC: PX.Objects.AM.AMWCOvhd 
		/// </summary>
		[DataMember(Name="Factor", EmitDefaultValue=false)]
		public DecimalValue? Factor { get; set; }

		/// <summary>
		/// DAC Field Name: OvhdID 
		/// DAC: PX.Objects.AM.AMWCOvhd 
		/// Display Name: Overhead ID 
		/// SQL Type: nvarchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Overhead", EmitDefaultValue=false)]
		public StringValue? Overhead { get; set; }

		/// <summary>
		/// DAC Field Name: AMOverhead__OvhdType 
		/// DAC: PX.Objects.AM.AMWCOvhd 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}