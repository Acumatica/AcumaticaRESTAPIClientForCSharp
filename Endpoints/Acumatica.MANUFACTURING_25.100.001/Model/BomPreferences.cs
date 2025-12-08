using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM101000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class BomPreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// A Boolean value that indicates whether users can archive the cost roll results without updating the pending costs.
		/// <para>DAC Field Name: AllowArchiveWithoutUpdatePending</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Allow Archive without Update Pending</para>
		/// </summary>
		[DataMember(Name="AllowArchivewithoutUpdatePending", EmitDefaultValue=false)]
		public BooleanValue? AllowArchivewithoutUpdatePending { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the BOM can be created without a subitem ID.
		/// <para>DAC Field Name: AllowEmptyBOMSubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Allow Empty BOM Item Sub Item ID</para>
		/// </summary>
		[DataMember(Name="AllowEmptyBOMItemSubItemID", EmitDefaultValue=false)]
		public BooleanValue? AllowEmptyBOMItemSubItemID { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the system will archive the cost roll results when a user updates pending costs.
		/// <para>DAC Field Name: AutoArchiveWhenUpdatePending</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Auto Archive when Update Pending</para>
		/// </summary>
		[DataMember(Name="AutoArchivewhenUpdatePending", EmitDefaultValue=false)]
		public BooleanValue? AutoArchivewhenUpdatePending { get; set; }

		/// <summary>
		/// The numbering sequence the system uses for assigning reference numbers to bills of material.
		/// <para>DAC Field Name: BOMNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: BOM Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="BOMNumberingSequence", EmitDefaultValue=false)]
		public StringValue? BOMNumberingSequence { get; set; }

		/// <summary>
		/// The time required for the semi-finished item to be prepared for the next operation when the current operation has been finished.
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Default Finish Time</para>
		/// </summary>
		[DataMember(Name="DefaultFinishTime", EmitDefaultValue=false)]
		public StringValue? DefaultFinishTime { get; set; }

		/// <summary>
		/// The time for a semi-finished item to be moved from the work center where the current operation is performed to the work center where the next operation will be performed.
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Default Move Time</para>
		/// </summary>
		[DataMember(Name="DefaultMoveTime", EmitDefaultValue=false)]
		public StringValue? DefaultMoveTime { get; set; }

		/// <summary>
		/// The time a semi-finished item has to wait in the work center before workers can start processing the item.
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Default Queue Time</para>
		/// </summary>
		[DataMember(Name="DefaultQueueTime", EmitDefaultValue=false)]
		public StringValue? DefaultQueueTime { get; set; }

		/// <summary>
		/// The default identifier of a revision for new bills of material, which is an alphanumeric string.
		/// <para>DAC Field Name: DefaultRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Default Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="DefaultRevision", EmitDefaultValue=false)]
		public StringValue? DefaultRevision { get; set; }

		/// <summary>
		/// The default work center that is specified for each operation that you add to a bill of material.
		/// <para>DAC Field Name: WcID</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Default Work Center</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="DefaultWorkCenter", EmitDefaultValue=false)]
		public StringValue? DefaultWorkCenter { get; set; }

		/// <summary>
		/// The option that controls the use of duplicate inventory items as materials in all operations of bills of material.(Previously DupInvBOM)
		/// <para>DAC Field Name: DuplicateItemOnBOM</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Duplicates on BOM</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="DuplicatesonBOM", EmitDefaultValue=false)]
		public StringValue? DuplicatesonBOM { get; set; }

		/// <summary>
		/// The option that controls the use of duplicate inventory items as materials added to each operation of a bill of material.(Previously DupInvOper)
		/// <para>DAC Field Name: DuplicateItemOnOper</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Duplicates on Operation</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="DuplicatesonOperation", EmitDefaultValue=false)]
		public StringValue? DuplicatesonOperation { get; set; }

		/// <summary>
		/// The numbering sequence the system uses for assigning reference numbers to engineering change orders (ECOs).
		/// <para>DAC Field Name: ECONumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: ECO Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ECONumberingSequence", EmitDefaultValue=false)]
		public StringValue? ECONumberingSequence { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the ECO needs to be approved.
		/// <para>DAC Field Name: ECORequestApproval</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: ECO Require Approval</para>
		/// </summary>
		[DataMember(Name="ECORequireApproval", EmitDefaultValue=false)]
		public BooleanValue? ECORequireApproval { get; set; }

		/// <summary>
		/// The numbering sequence the system uses for assigning reference numbers to engineering change requests (ECRs).
		/// <para>DAC Field Name: ECRNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: ECR Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ECRNumberingSequence", EmitDefaultValue=false)]
		public StringValue? ECRNumberingSequence { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the ECR needs to be approved.
		/// <para>DAC Field Name: ECRRequestApproval</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: ECR Require Approval</para>
		/// </summary>
		[DataMember(Name="ECRRequireApproval", EmitDefaultValue=false)]
		public BooleanValue? ECRRequireApproval { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the new BOM revisions have the On Hold status. 
		/// <para>DAC Field Name: BOMHoldRevisionsOnEntry</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Hold BOM Revisions on Entry</para>
		/// </summary>
		[DataMember(Name="HoldBOMRevisionsonEntry", EmitDefaultValue=false)]
		public BooleanValue? HoldBOMRevisionsonEntry { get; set; }

		/// <summary>
		/// The format that is used in the columns with time settings in the operations.
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Operation Time Format</para>
		/// </summary>
		[DataMember(Name="OperationTimeFormat", EmitDefaultValue=false)]
		public StringValue? OperationTimeFormat { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the ECR or ECO is required for new BOM revisions.
		/// <para>DAC Field Name: ForceECR</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Require ECR/ECO for New BOM Revisions</para>
		/// </summary>
		[DataMember(Name="PreventNewRevisionsWithoutECR", EmitDefaultValue=false)]
		public BooleanValue? PreventNewRevisionsWithoutECR { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the ECR is required before creating ECO.
		/// <para>DAC Field Name: RequireECRBeforeECO</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Require ECR Before Creating ECO</para>
		/// </summary>
		[DataMember(Name="RequireECRbeforeCreatingECO", EmitDefaultValue=false)]
		public BooleanValue? RequireECRbeforeCreatingECO { get; set; }

		/// <summary>
		/// The time format that is used for total time values.
		/// <para>DAC Field Name: ProductionTimeFormat</para>
		/// <para>DAC: PX.Objects.AM.AMBSetup</para>
		/// <para>Display Name: Total Time Format</para>
		/// </summary>
		[DataMember(Name="TotalTimeFormat", EmitDefaultValue=false)]
		public StringValue? TotalTimeFormat { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}