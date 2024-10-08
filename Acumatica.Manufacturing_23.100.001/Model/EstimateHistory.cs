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
	public class EstimateHistory : Entity
	{

		/// <summary>
		/// The date and time when the record was created.
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.AM.AMEstimateHistory 
		/// Display Name: Created At 
		/// </summary>
		[DataMember(Name="CreatedAt", EmitDefaultValue=false)]
		public DateTimeValue? CreatedAt { get; set; }

		/// <summary>
		/// The ID of the user who created the record.
		/// DAC Field Name: CreatedByID 
		/// DAC: PX.Objects.AM.AMEstimateHistory 
		/// Display Name: Created By 
		/// </summary>
		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue? CreatedBy { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Operation Desc 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Estimate ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="EstimateID", EmitDefaultValue=false)]
		public StringValue? EstimateID { get; set; }

		[DataMember(Name="HistoryLineNumber", EmitDefaultValue=false)]
		public IntValue? HistoryLineNumber { get; set; }

		/// <summary>
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

	}
}