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
	public class DisassemblyEntryAttribute : Entity
	{

		/// <summary>
		/// DAC Field Name: Label 
		/// DAC: PX.Objects.AM.AMDisassembleBatchAttribute 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="Attribute", EmitDefaultValue=false)]
		public StringValue? Attribute { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleBatchAttribute 
		/// Display Name: Attribute ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMDisassembleBatchAttribute 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleTran 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="ProdAttributeLineNbr", EmitDefaultValue=false)]
		public IntValue? ProdAttributeLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: TransactionRequired 
		/// DAC: PX.Objects.AM.AMDisassembleBatchAttribute 
		/// </summary>
		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue? Required { get; set; }

		[DataMember(Name="TranLineNbr", EmitDefaultValue=false)]
		public IntValue? TranLineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleBatchAttribute 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}