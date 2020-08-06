using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ChangeProjectID : EntityActionWithParameters<Project, ChangeProjectIDParameters>
	{
		public ChangeProjectID() : base()
		{ }
		public ChangeProjectID(Project entity, ChangeProjectIDParameters parameters) : base(entity, parameters)
		{ }

		public StringValue ProjectID
		{
			get { return Parameters.ProjectID; }
			set { Parameters.ProjectID = value; }
		}
	}
}