using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class EmployeeDelegate : Entity
	{

		[DataMember(Name="Delegate", EmitDefaultValue=false)]
		public StringValue Delegate { get; set; }

		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue EmployeeName { get; set; }

	}
}