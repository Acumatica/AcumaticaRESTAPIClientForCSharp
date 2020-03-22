using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class Carrier : Entity
	{

		[DataMember(Name="CarrierID", EmitDefaultValue=false)]
		public StringValue CarrierID { get; set; }

		[DataMember(Name="CarrierUnitOfWeight", EmitDefaultValue=false)]
		public StringValue CarrierUnitOfWeight { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="CustomerAccounts", EmitDefaultValue=false)]
		public List<CarrierCustomerAccount> CustomerAccounts { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="PlugInParameters", EmitDefaultValue=false)]
		public List<CarrierPluginParameter> PlugInParameters { get; set; }

		[DataMember(Name="PlugInType", EmitDefaultValue=false)]
		public StringValue PlugInType { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

	}
}