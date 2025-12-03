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
	/// Corresponds to the screen <c>PR101040</c> in the Acumatica ERP
	/// <para>Key Fields: WorkLocationID</para>
	/// </summary>
	[DataContract]
	public class WorkLocation : Entity, ITopLevelEntity
	{

		/// <summary>
		/// A boolean value that specifies (if set to true) that the location is used.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PR.PRLocation</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AddressInfo", EmitDefaultValue=false)]
		public Address? AddressInfo { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The unique identifier of the branch to which the work location belongs.The field is included in Branch.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.PR.PRLocation</para>
		/// <para>Display Name: Use Address from Branch ID</para>
		/// </summary>
		[DataMember(Name="UseAddressfromBranchID", EmitDefaultValue=false)]
		public StringValue? UseAddressfromBranchID { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the work location.
		/// <para>DAC Field Name: LocationCD</para>
		/// <para>DAC: PX.Objects.PR.PRLocation</para>
		/// <para>Display Name: Location ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="WorkLocationID", EmitDefaultValue=false)]
		public StringValue? WorkLocationID { get; set; }

		/// <summary>
		/// The description.
		/// <para>DAC Field Name: Description</para>
		/// <para>DAC: PX.Objects.PR.PRLocation</para>
		/// <para>Display Name: Location Name</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="WorkLocationName", EmitDefaultValue=false)]
		public StringValue? WorkLocationName { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string AddressInfo = "AddressInfo";

			//Intentionally excluded
			//public const string All = "Files,AddressInfo";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}