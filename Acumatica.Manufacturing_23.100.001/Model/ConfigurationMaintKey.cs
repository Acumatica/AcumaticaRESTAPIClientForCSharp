using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class ConfigurationMaintKey : Entity
	{

		/// <summary>
		/// DAC Field Name: KeyFormat 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Format", EmitDefaultValue=false)]
		public StringValue? Format { get; set; }

		/// <summary>
		/// DAC Field Name: KeyEquation 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// SQL Type: nvarchar(240) 
		/// </summary>
		[DataMember(Name="Formula", EmitDefaultValue=false)]
		public StringValue? Formula { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// Display Name: Key Description 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="KeyDescription", EmitDefaultValue=false)]
		public StringValue? KeyDescription { get; set; }

		/// <summary>
		/// DAC Field Name: KeyNumberingID 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// Display Name: Number Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="NumberSequence", EmitDefaultValue=false)]
		public StringValue? NumberSequence { get; set; }

		/// <summary>
		/// Formula field to configure a custom transaction description for sales order tran description.
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// Display Name: Tran Description 
		/// SQL Type: nvarchar(512) 
		/// </summary>
		[DataMember(Name="TranDescription", EmitDefaultValue=false)]
		public StringValue? TranDescription { get; set; }

	}
}