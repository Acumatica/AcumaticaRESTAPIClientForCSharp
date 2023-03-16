using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmploymentDates : Entity
	{

		[DataMember(Name="HireDate", EmitDefaultValue=false)]
		public DateTimeValue HireDate { get; set; }

		[DataMember(Name="TerminationDate", EmitDefaultValue=false)]
		public DateTimeValue TerminationDate { get; set; }

	}
}