using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class BomPreferences : Entity
	{

		[DataMember(Name="AllowArchivewithoutUpdatePending", EmitDefaultValue=false)]
		public BooleanValue AllowArchivewithoutUpdatePending { get; set; }

		[DataMember(Name="AllowEmptyBOMItemSubItemID", EmitDefaultValue=false)]
		public BooleanValue AllowEmptyBOMItemSubItemID { get; set; }

		[DataMember(Name="AutoArchivewhenUpdatePending", EmitDefaultValue=false)]
		public BooleanValue AutoArchivewhenUpdatePending { get; set; }

		[DataMember(Name="BOMNumberingSequence", EmitDefaultValue=false)]
		public StringValue BOMNumberingSequence { get; set; }

		[DataMember(Name="DefaultRevision", EmitDefaultValue=false)]
		public StringValue DefaultRevision { get; set; }

		[DataMember(Name="DefaultWorkCenter", EmitDefaultValue=false)]
		public StringValue DefaultWorkCenter { get; set; }

		[DataMember(Name="DuplicatesonBOM", EmitDefaultValue=false)]
		public StringValue DuplicatesonBOM { get; set; }

		[DataMember(Name="DuplicatesonOperation", EmitDefaultValue=false)]
		public StringValue DuplicatesonOperation { get; set; }

		[DataMember(Name="ECONumberingSequence", EmitDefaultValue=false)]
		public StringValue ECONumberingSequence { get; set; }

		[DataMember(Name="ECORequireApproval", EmitDefaultValue=false)]
		public BooleanValue ECORequireApproval { get; set; }

		[DataMember(Name="ECRNumberingSequence", EmitDefaultValue=false)]
		public StringValue ECRNumberingSequence { get; set; }

		[DataMember(Name="ECRRequireApproval", EmitDefaultValue=false)]
		public BooleanValue ECRRequireApproval { get; set; }

		[DataMember(Name="OperationTimeFormat", EmitDefaultValue=false)]
		public StringValue OperationTimeFormat { get; set; }

		[DataMember(Name="PreventNewRevisionsWithoutECR", EmitDefaultValue=false)]
		public BooleanValue PreventNewRevisionsWithoutECR { get; set; }

		[DataMember(Name="TotalTimeFormat", EmitDefaultValue=false)]
		public StringValue TotalTimeFormat { get; set; }

	}
}