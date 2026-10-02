using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PR101040</c> in the Acumatica ERP
	/// <para>Key Fields: WorkLocationID</para>
	/// </summary>
	public class WorkLocation : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// The user-friendly unique identifier of the work location.
		/// <para>DAC Field Name: LocationCD</para>
		/// <para>DAC: PX.Objects.PR.PRLocation</para>
		/// <para>Display Name: Location ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? WorkLocationID { get; set; }

		/// <summary>
		/// The description.
		/// <para>DAC Field Name: Description</para>
		/// <para>DAC: PX.Objects.PR.PRLocation</para>
		/// <para>Display Name: Location Name</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? WorkLocationName { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the location is used.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PR.PRLocation</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// The unique identifier of the branch to which the work location belongs.The field is included in Branch.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.PR.PRLocation</para>
		/// <para>Display Name: Use Address from Branch ID</para>
		/// </summary>
		public StringValue? UseAddressfromBranchID { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

		#region LinkedEntities
		public Address? AddressInfo { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(WorkLocation)} - \"{WorkLocationID}\"";
		}

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string AddressInfo = "AddressInfo";

			//Intentionally excluded
			//public const string All = "Files,Translations,AddressInfo";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}