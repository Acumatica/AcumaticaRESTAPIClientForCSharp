using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PR101040 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class WorkLocation : Entity, ITopLevelEntity
	{

		/// <summary>
		/// A boolean value that specifies (if set to true) that the location is used.
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.PR.PRLocation 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AddressInfo", EmitDefaultValue=false)]
		public Address? AddressInfo { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The unique identifier of the branch to which the work location belongs.The field is included in Branch.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.PR.PRLocation 
		/// Display Name: Use Address from Branch ID 
		/// </summary>
		[DataMember(Name="UseAddressfromBranchID", EmitDefaultValue=false)]
		public StringValue? UseAddressfromBranchID { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the work location.
		/// DAC Field Name: LocationCD 
		/// DAC: PX.Objects.PR.PRLocation 
		/// Display Name: Location ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="WorkLocationID", EmitDefaultValue=false)]
		public StringValue? WorkLocationID { get; set; }

		/// <summary>
		/// The description.
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.PR.PRLocation 
		/// Display Name: Location Name 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="WorkLocationName", EmitDefaultValue=false)]
		public StringValue? WorkLocationName { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}