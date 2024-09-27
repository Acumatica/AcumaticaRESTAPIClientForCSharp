using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen IN207000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class LotSerialClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: LotSerAssign 
		/// DAC: PX.Objects.IN.INLotSerClass 
		/// Display Name: Assignment Method 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="AssignmentMethod", EmitDefaultValue=false)]
		public StringValue? AssignmentMethod { get; set; }

		/// <summary>
		/// DAC Field Name: LotSerClassID 
		/// DAC: PX.Objects.IN.INLotSerClass 
		/// Display Name: Class ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.INLotSerClass 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: LotSerIssueMethod 
		/// DAC: PX.Objects.IN.INLotSerClass 
		/// Display Name: Issue Method 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="IssueMethod", EmitDefaultValue=false)]
		public StringValue? IssueMethod { get; set; }

		[DataMember(Name="Segments", EmitDefaultValue=false)]
		public List<LotSerialClassSegment>? Segments { get; set; }

		/// <summary>
		/// DAC Field Name: LotSerTrackExpiration 
		/// DAC: PX.Objects.IN.INLotSerClass 
		/// Display Name: Track Expiration Date 
		/// </summary>
		[DataMember(Name="TrackExpirationDate", EmitDefaultValue=false)]
		public BooleanValue? TrackExpirationDate { get; set; }

		/// <summary>
		/// DAC Field Name: LotSerTrack 
		/// DAC: PX.Objects.IN.INLotSerClass 
		/// Display Name: Tracking Method 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="TrackingMethod", EmitDefaultValue=false)]
		public StringValue? TrackingMethod { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}