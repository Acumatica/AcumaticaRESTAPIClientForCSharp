using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM202500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Overhead : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: AcctID 
		/// DAC: PX.Objects.AM.AMOverhead 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMOverhead 
		/// Display Name: Cost Rate 
		/// </summary>
		[DataMember(Name="CostRate", EmitDefaultValue=false)]
		public DecimalValue? CostRate { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMOverhead 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: OvhdID 
		/// DAC: PX.Objects.AM.AMOverhead 
		/// Display Name: Overhead ID 
		/// SQL Type: nvarchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OverheadID", EmitDefaultValue=false)]
		public StringValue? OverheadID { get; set; }

		/// <summary>
		/// DAC Field Name: OvhdType 
		/// DAC: PX.Objects.AM.AMOverhead 
		/// Display Name: Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="OverheadType", EmitDefaultValue=false)]
		public StringValue? OverheadType { get; set; }

		/// <summary>
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.AM.AMOverhead 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}