using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ChangeEmployeeID : EntityActionWithParameters<Employee, ChangeEmployeeIDParameters>
	{
		public ChangeEmployeeID() : base()
		{ }
		public ChangeEmployeeID(Employee entity, ChangeEmployeeIDParameters parameters) : base(entity, parameters)
		{ }

		public StringValue EmployeeID
		{
			get { return Parameters.EmployeeID; }
			set { Parameters.EmployeeID = value; }
		}
	}
}