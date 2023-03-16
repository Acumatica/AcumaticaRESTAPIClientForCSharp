using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EstimateHistory : Entity
	{

		[DataMember(Name="CreatedAt", EmitDefaultValue=false)]
		public DateTimeValue CreatedAt { get; set; }

		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue CreatedBy { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EstimateID", EmitDefaultValue=false)]
		public StringValue EstimateID { get; set; }

		[DataMember(Name="HistoryLineNumber", EmitDefaultValue=false)]
		public IntValue HistoryLineNumber { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

	}
}