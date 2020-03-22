using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class LinkEntityToTask : EntityActionWithParameters<Task, LinkEntityToTaskParameters>
	{
		public LinkEntityToTask() : base()
		{ }
		public LinkEntityToTask(Task entity, LinkEntityToTaskParameters parameters) : base(entity, parameters)
		{ }

		public StringValue RelatedEntity
		{
			get { return Parameters.RelatedEntity; }
			set { Parameters.RelatedEntity = value; }
		}
		public StringValue Type
		{
			get { return Parameters.Type; }
			set { Parameters.Type = value; }
		}
	}
}