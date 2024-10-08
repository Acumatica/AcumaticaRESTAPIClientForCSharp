using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM101000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class BomPreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// A Boolean value that indicates whether users can archive the cost roll results without updating the pending costs.
		/// DAC Field Name: AllowArchiveWithoutUpdatePending 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Allow Archive without Update Pending 
		/// </summary>
		[DataMember(Name="AllowArchivewithoutUpdatePending", EmitDefaultValue=false)]
		public BooleanValue? AllowArchivewithoutUpdatePending { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the BOM can be created without a subitem ID.
		/// DAC Field Name: AllowEmptyBOMSubItemID 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Allow Empty BOM Item Sub Item ID 
		/// </summary>
		[DataMember(Name="AllowEmptyBOMItemSubItemID", EmitDefaultValue=false)]
		public BooleanValue? AllowEmptyBOMItemSubItemID { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the system will archive the cost roll results when a user updates pending costs.
		/// DAC Field Name: AutoArchiveWhenUpdatePending 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Auto Archive when Update Pending 
		/// </summary>
		[DataMember(Name="AutoArchivewhenUpdatePending", EmitDefaultValue=false)]
		public BooleanValue? AutoArchivewhenUpdatePending { get; set; }

		/// <summary>
		/// The numbering sequence the system uses for assigning reference numbers to bills of material.
		/// DAC Field Name: BOMNumberingID 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: BOM Numbering Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="BOMNumberingSequence", EmitDefaultValue=false)]
		public StringValue? BOMNumberingSequence { get; set; }

		/// <summary>
		/// The time required for the semi-finished item to be prepared for the next operation when the current operation has been finished.
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Default Finish Time 
		/// </summary>
		[DataMember(Name="DefaultFinishTime", EmitDefaultValue=false)]
		public StringValue? DefaultFinishTime { get; set; }

		/// <summary>
		/// The time for a semi-finished item to be moved from the work center where the current operation is performed to the work center where the next operation will be performed.
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Default Move Time 
		/// </summary>
		[DataMember(Name="DefaultMoveTime", EmitDefaultValue=false)]
		public StringValue? DefaultMoveTime { get; set; }

		/// <summary>
		/// The time a semi-finished item has to wait in the work center before workers can start processing the item.
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Default Queue Time 
		/// </summary>
		[DataMember(Name="DefaultQueueTime", EmitDefaultValue=false)]
		public StringValue? DefaultQueueTime { get; set; }

		/// <summary>
		/// The default identifier of a revision for new bills of material, which is an alphanumeric string.
		/// DAC Field Name: DefaultRevisionID 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Default Revision 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="DefaultRevision", EmitDefaultValue=false)]
		public StringValue? DefaultRevision { get; set; }

		/// <summary>
		/// The default work center that is specified for each operation that you add to a bill of material.
		/// DAC Field Name: WcID 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Default Work Center 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="DefaultWorkCenter", EmitDefaultValue=false)]
		public StringValue? DefaultWorkCenter { get; set; }

		/// <summary>
		/// The option that controls the use of duplicate inventory items as materials in all operations of bills of material.(Previously DupInvBOM)
		/// DAC Field Name: DuplicateItemOnBOM 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Duplicates on BOM 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="DuplicatesonBOM", EmitDefaultValue=false)]
		public StringValue? DuplicatesonBOM { get; set; }

		/// <summary>
		/// The option that controls the use of duplicate inventory items as materials added to each operation of a bill of material.(Previously DupInvOper)
		/// DAC Field Name: DuplicateItemOnOper 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Duplicates on Operation 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="DuplicatesonOperation", EmitDefaultValue=false)]
		public StringValue? DuplicatesonOperation { get; set; }

		/// <summary>
		/// The numbering sequence the system uses for assigning reference numbers to engineering change orders (ECOs).
		/// DAC Field Name: ECONumberingID 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: ECO Numbering Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ECONumberingSequence", EmitDefaultValue=false)]
		public StringValue? ECONumberingSequence { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the ECO needs to be approved.
		/// DAC Field Name: ECORequestApproval 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: ECO Require Approval 
		/// </summary>
		[DataMember(Name="ECORequireApproval", EmitDefaultValue=false)]
		public BooleanValue? ECORequireApproval { get; set; }

		/// <summary>
		/// The numbering sequence the system uses for assigning reference numbers to engineering change requests (ECRs).
		/// DAC Field Name: ECRNumberingID 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: ECR Numbering Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ECRNumberingSequence", EmitDefaultValue=false)]
		public StringValue? ECRNumberingSequence { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the ECR needs to be approved.
		/// DAC Field Name: ECRRequestApproval 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: ECR Require Approval 
		/// </summary>
		[DataMember(Name="ECRRequireApproval", EmitDefaultValue=false)]
		public BooleanValue? ECRRequireApproval { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the new BOM revisions have the On Hold status. 
		/// DAC Field Name: BOMHoldRevisionsOnEntry 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Hold BOM Revisions on Entry 
		/// </summary>
		[DataMember(Name="HoldBOMRevisionsonEntry", EmitDefaultValue=false)]
		public BooleanValue? HoldBOMRevisionsonEntry { get; set; }

		/// <summary>
		/// The format that is used in the columns with time settings in the operations.
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Operation Time Format 
		/// </summary>
		[DataMember(Name="OperationTimeFormat", EmitDefaultValue=false)]
		public StringValue? OperationTimeFormat { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the ECR or ECO is required for new BOM revisions.
		/// DAC Field Name: ForceECR 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Require ECR/ECO for New BOM Revisions 
		/// </summary>
		[DataMember(Name="PreventNewRevisionsWithoutECR", EmitDefaultValue=false)]
		public BooleanValue? PreventNewRevisionsWithoutECR { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the ECR is required before creating ECO.
		/// DAC Field Name: RequireECRBeforeECO 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Require ECR Before Creating ECO 
		/// </summary>
		[DataMember(Name="RequireECRbeforeCreatingECO", EmitDefaultValue=false)]
		public BooleanValue? RequireECRbeforeCreatingECO { get; set; }

		/// <summary>
		/// The time format that is used for total time values.
		/// DAC Field Name: ProductionTimeFormat 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// Display Name: Total Time Format 
		/// </summary>
		[DataMember(Name="TotalTimeFormat", EmitDefaultValue=false)]
		public StringValue? TotalTimeFormat { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}