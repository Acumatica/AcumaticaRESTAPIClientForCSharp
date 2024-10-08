using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	[DataContract]
	public class EngineeringChangeRequestAttribute : Entity
	{

		/// <summary>
		/// The ID of the attribute.
		/// DAC: PX.Objects.AM.AMBomAttribute 
		/// Display Name: Attribute ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// The change status.
		/// DAC Field Name: RowStatus 
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Change Status 
		/// </summary>
		[DataMember(Name="ChangeStatus", EmitDefaultValue=false)]
		public StringValue? ChangeStatus { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMECRItem 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: BOMID 
		/// DAC: PX.Objects.AM.AMECRItem 
		/// Display Name: BOM ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ECRID", EmitDefaultValue=false)]
		public StringValue? ECRID { get; set; }

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
		/// The numeric identifier of the operation, which determines the sequence in which the operation is executed in production orders.
		/// DAC: PX.Objects.AM.AMBomOper 
		/// Display Name: Operation ID 
		/// </summary>
		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// The field that specifies where the attribute can be used.
		/// DAC: PX.Objects.AM.AMBomAttribute 
		/// Display Name: Order Function 
		/// </summary>
		[DataMember(Name="OrderFunction", EmitDefaultValue=false)]
		public StringValue? OrderFunction { get; set; }

		/// <summary>
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.AMECRItem 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the value must be specified before the production transaction batch is released.
		/// DAC: PX.Objects.AM.AMBomAttribute 
		/// Display Name: Transaction Required 
		/// </summary>
		[DataMember(Name="TransactionRequired", EmitDefaultValue=false)]
		public BooleanValue? TransactionRequired { get; set; }

		/// <summary>
		/// The default value that is copied onto the production order or operation.
		/// DAC: PX.Objects.AM.AMBomAttribute 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}