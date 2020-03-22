using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ChangeEmployeeID : EntityActionWithParameters<Employee, ChangeEmployeeIDParameters>
	{
		public ChangeEmployeeID() : base()
		{ }
		public ChangeEmployeeID(Employee entity, ChangeEmployeeIDParameters parameters) : base(entity, parameters)
		{ }
	}
}