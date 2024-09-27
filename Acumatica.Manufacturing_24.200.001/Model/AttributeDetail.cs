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
	public class AttributeDetail : Entity
	{

		/// <summary>
		/// The identifier of the bill of material.
		/// DAC Field Name: BOMID 
		/// DAC: PX.Objects.AM.AMBomItem 
		/// Display Name: BOM ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="AttributeBOMID", EmitDefaultValue=false)]
		public StringValue? AttributeBOMID { get; set; }

		/// <summary>
		/// The ID of the attribute.
		/// DAC: PX.Objects.AM.AMBomAttribute 
		/// Display Name: Attribute ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// The default value that is copied onto the production order or operation.
		/// DAC Field Name: Value 
		/// DAC: PX.Objects.AM.AMBomAttribute 
		/// Display Name: Value 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="DefaultValue", EmitDefaultValue=false)]
		public StringValue? DefaultValue { get; set; }

		/// <summary>
		/// A description of the bill of material. The system copies the description to production orders that are created by using the bill of material.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMBomItem 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the value can be changed in the production order and entered when reporting production.
		/// DAC: PX.Objects.AM.AMBomAttribute 
		/// </summary>
		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// The unique label.
		/// DAC: PX.Objects.AM.AMBomAttribute 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		/// <summary>
		/// The attribute level, which is specified automatically.
		/// DAC: PX.Objects.AM.AMBomAttribute 
		/// </summary>
		[DataMember(Name="Level", EmitDefaultValue=false)]
		public StringValue? Level { get; set; }

		/// <summary>
		/// The line number.
		/// DAC: PX.Objects.AM.AMBomAttribute 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// The operation number from the bill of material.
		/// DAC Field Name: OperationID 
		/// DAC: PX.Objects.AM.AMBomAttribute 
		/// Display Name: Operation ID 
		/// </summary>
		[DataMember(Name="OperNbr", EmitDefaultValue=false)]
		public StringValue? OperNbr { get; set; }

		/// <summary>
		/// The field that specifies where the attribute can be used.
		/// DAC: PX.Objects.AM.AMBomAttribute 
		/// Display Name: Order Function 
		/// </summary>
		[DataMember(Name="OrderFunction", EmitDefaultValue=false)]
		public StringValue? OrderFunction { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the value must be specified before the production transaction batch is released.
		/// DAC: PX.Objects.AM.AMBomAttribute 
		/// Display Name: Transaction Required 
		/// </summary>
		[DataMember(Name="TransactionRequired", EmitDefaultValue=false)]
		public BooleanValue? TransactionRequired { get; set; }

	}
}