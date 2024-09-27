using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PM209500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CostCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Get or sets unique identifier.This is a segmented key and format is configured under segmented key maintenance screen in CS module.
		/// DAC Field Name: CostCodeCD 
		/// DAC: PX.Objects.PM.PMCostCode 
		/// Display Name: Cost Code 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="CostCodeID", EmitDefaultValue=false)]
		public StringValue? CostCodeID { get; set; }

		/// <summary>
		/// Gets or sets description
		/// DAC: PX.Objects.PM.PMCostCode 
		/// SQL Type: nvarchar(250) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}