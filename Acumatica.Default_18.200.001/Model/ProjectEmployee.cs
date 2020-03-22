using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ProjectEmployee : Entity
	{

		[DataMember(Name="Department", EmitDefaultValue=false)]
		public StringValue Department { get; set; }

		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue EmployeeID { get; set; }

		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue EmployeeName { get; set; }

	}
}