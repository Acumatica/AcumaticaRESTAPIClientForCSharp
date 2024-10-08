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
	public class EventHistoryDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: RefBatNbr 
		/// DAC: PX.Objects.AM.AMProdEvnt 
		/// Display Name: Batch Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.AM.AMProdEvnt 
		/// Display Name: Created At 
		/// </summary>
		[DataMember(Name="CreatedAt", EmitDefaultValue=false)]
		public DateTimeValue? CreatedAt { get; set; }

		/// <summary>
		/// The ID of the user who created the record.
		/// DAC Field Name: CreatedByID 
		/// DAC: PX.Objects.AM.AMProdEvnt 
		/// Display Name: Created By 
		/// </summary>
		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue? CreatedBy { get; set; }

		[DataMember(Name="CreatedScreen", EmitDefaultValue=false)]
		public StringValue? CreatedScreen { get; set; }

		/// <summary>
		/// The ID of the form that was used for the creation of the record.
		/// DAC Field Name: CreatedByScreenID 
		/// DAC: PX.Objects.AM.AMProdEvnt 
		/// Display Name: Created Screen ID 
		/// SQL Type: char(8) 
		/// </summary>
		[DataMember(Name="CreatedScreenID", EmitDefaultValue=false)]
		public StringValue? CreatedScreenID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdEvnt 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: RefDocType 
		/// DAC: PX.Objects.AM.AMProdEvnt 
		/// Display Name: Doc Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		[DataMember(Name="EventID", EmitDefaultValue=false)]
		public LongValue? EventID { get; set; }

		/// <summary>
		/// DAC Field Name: LineNbr 
		/// DAC: PX.Objects.AM.AMProdEvnt 
		/// Display Name: Event Line Number 
		/// Key Field
		/// </summary>
		[DataMember(Name="EventLineNumber", EmitDefaultValue=false)]
		public IntValue? EventLineNumber { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public GuidValue? RelatedDocument { get; set; }

		/// <summary>
		/// DAC Field Name: EventType 
		/// DAC: PX.Objects.AM.AMProdEvnt 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}