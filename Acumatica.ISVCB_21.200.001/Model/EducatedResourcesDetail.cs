using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_21_200_001.Model
{
	[DataContract]
	public class EducatedResourcesDetail : Entity
	{

		[DataMember(Name="Geography", EmitDefaultValue=false)]
		public StringValue? Geography { get; set; }

		[DataMember(Name="AccountID", EmitDefaultValue=false)]
		public StringValue? AccountID { get; set; }

		[DataMember(Name="AccountName", EmitDefaultValue=false)]
		public StringValue? AccountName { get; set; }

		[DataMember(Name="StageID", EmitDefaultValue=false)]
		public StringValue? StageID { get; set; }

		[DataMember(Name="StageName", EmitDefaultValue=false)]
		public StringValue? StageName { get; set; }

		[DataMember(Name="StageStatus", EmitDefaultValue=false)]
		public StringValue? StageStatus { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="Contact", EmitDefaultValue=false)]
		public StringValue? Contact { get; set; }

		[DataMember(Name="FirstName", EmitDefaultValue=false)]
		public StringValue? FirstName { get; set; }

		[DataMember(Name="LastName", EmitDefaultValue=false)]
		public StringValue? LastName { get; set; }

		[DataMember(Name="BadgeID", EmitDefaultValue=false)]
		public StringValue? BadgeID { get; set; }

		[DataMember(Name="BadgeName", EmitDefaultValue=false)]
		public StringValue? BadgeName { get; set; }

		[DataMember(Name="BadgeStatus", EmitDefaultValue=false)]
		public StringValue? BadgeStatus { get; set; }

		[DataMember(Name="AddressLine1", EmitDefaultValue=false)]
		public StringValue? AddressLine1 { get; set; }

		[DataMember(Name="AddressLine2", EmitDefaultValue=false)]
		public StringValue? AddressLine2 { get; set; }

		[DataMember(Name="AddressLine3", EmitDefaultValue=false)]
		public StringValue? AddressLine3 { get; set; }

		[DataMember(Name="City", EmitDefaultValue=false)]
		public StringValue? City { get; set; }

		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

		[DataMember(Name="StateName", EmitDefaultValue=false)]
		public StringValue? StateName { get; set; }

		[DataMember(Name="PostalCode", EmitDefaultValue=false)]
		public StringValue? PostalCode { get; set; }

		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		[DataMember(Name="CountryName", EmitDefaultValue=false)]
		public StringValue? CountryName { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		[DataMember(Name="ContractTemplate", EmitDefaultValue=false)]
		public StringValue? ContractTemplate { get; set; }

		[DataMember(Name="Class", EmitDefaultValue=false)]
		public StringValue? Class { get; set; }

		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue? Module { get; set; }

		[DataMember(Name="ContactwithBadge", EmitDefaultValue=false)]
		public StringValue? ContactwithBadge { get; set; }

		[DataMember(Name="ContactStatus", EmitDefaultValue=false)]
		public BooleanValue? ContactStatus { get; set; }

		[DataMember(Name="UserLogin", EmitDefaultValue=false)]
		public StringValue? UserLogin { get; set; }

		[DataMember(Name="UserType", EmitDefaultValue=false)]
		public StringValue? UserType { get; set; }

		[DataMember(Name="CourseProgress", EmitDefaultValue=false)]
		public IntValue? CourseProgress { get; set; }

		[DataMember(Name="AchievementDate", EmitDefaultValue=false)]
		public DateTimeValue? AchievementDate { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		[DataMember(Name="Achieved", EmitDefaultValue=false)]
		public BooleanValue? Achieved { get; set; }

		[DataMember(Name="PrerequisiteAchievement", EmitDefaultValue=false)]
		public IntValue? PrerequisiteAchievement { get; set; }

		[DataMember(Name="CourseAchievement", EmitDefaultValue=false)]
		public IntValue? CourseAchievement { get; set; }

		[DataMember(Name="CreatedDate", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDate { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		[DataMember(Name="LastUCPDate", EmitDefaultValue=false)]
		public DateTimeValue? LastUCPDate { get; set; }

	}
}