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
	public class EngineeringChangeOrderAttribute : Entity
	{

		/// <summary>
		/// The ID of the attribute.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// <para>Display Name: Attribute ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// The change status.
		/// <para>DAC Field Name: RowStatus</para>
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Change Status</para>
		/// </summary>
		[DataMember(Name="ChangeStatus", EmitDefaultValue=false)]
		public StringValue? ChangeStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BOMID</para>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ECOID", EmitDefaultValue=false)]
		public StringValue? ECOID { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the value can be changed in the production order and entered when reporting production.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// </summary>
		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// The unique label.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		/// <summary>
		/// The attribute level, which is specified automatically.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// </summary>
		[DataMember(Name="Level", EmitDefaultValue=false)]
		public StringValue? Level { get; set; }

		/// <summary>
		/// The line number.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// The numeric identifier of the operation, which determines the sequence in which the operation is executed in production orders.
		/// <para>DAC: PX.Objects.AM.AMBomOper</para>
		/// <para>Display Name: Operation ID</para>
		/// </summary>
		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// The field that specifies where the attribute can be used.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// <para>Display Name: Order Function</para>
		/// </summary>
		[DataMember(Name="OrderFunction", EmitDefaultValue=false)]
		public StringValue? OrderFunction { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the value must be specified before the production transaction batch is released.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// <para>Display Name: Transaction Required</para>
		/// </summary>
		[DataMember(Name="TransactionRequired", EmitDefaultValue=false)]
		public BooleanValue? TransactionRequired { get; set; }

		/// <summary>
		/// The default value that is copied onto the production order or operation.
		/// <para>DAC: PX.Objects.AM.AMBomAttribute</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}