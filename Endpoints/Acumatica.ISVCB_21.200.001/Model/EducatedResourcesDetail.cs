using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_21_200_001.Model
{
	public class EducatedResourcesDetail : Entity
	{

		public StringValue? Geography { get; set; }

		public StringValue? AccountID { get; set; }

		public StringValue? AccountName { get; set; }

		public StringValue? StageID { get; set; }

		public StringValue? StageName { get; set; }

		public StringValue? StageStatus { get; set; }

		public IntValue? ContactID { get; set; }

		public StringValue? Contact { get; set; }

		public StringValue? FirstName { get; set; }

		public StringValue? LastName { get; set; }

		public StringValue? BadgeID { get; set; }

		public StringValue? BadgeName { get; set; }

		public StringValue? BadgeStatus { get; set; }

		public StringValue? AddressLine1 { get; set; }

		public StringValue? AddressLine2 { get; set; }

		public StringValue? AddressLine3 { get; set; }

		public StringValue? City { get; set; }

		public StringValue? State { get; set; }

		public StringValue? StateName { get; set; }

		public StringValue? PostalCode { get; set; }

		public StringValue? Country { get; set; }

		public StringValue? CountryName { get; set; }

		public StringValue? Email { get; set; }

		public StringValue? Phone1 { get; set; }

		public StringValue? ContractTemplate { get; set; }

		public StringValue? Class { get; set; }

		public StringValue? Module { get; set; }

		public StringValue? ContactwithBadge { get; set; }

		public BooleanValue? ContactStatus { get; set; }

		public StringValue? UserLogin { get; set; }

		public StringValue? UserType { get; set; }

		public IntValue? CourseProgress { get; set; }

		public DateTimeValue? AchievementDate { get; set; }

		public StringValue? Owner { get; set; }

		public BooleanValue? Achieved { get; set; }

		public IntValue? PrerequisiteAchievement { get; set; }

		public IntValue? CourseAchievement { get; set; }

		public DateTimeValue? CreatedDate { get; set; }

		public DateTimeValue? ExpirationDate { get; set; }

		public DateTimeValue? LastUCPDate { get; set; }

	}
}