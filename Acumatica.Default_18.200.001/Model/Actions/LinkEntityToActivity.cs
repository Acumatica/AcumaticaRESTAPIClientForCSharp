using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class LinkEntityToActivity : EntityActionWithParameters<Activity, LinkEntityToActivityParameters>
	{
		public LinkEntityToActivity() : base()
		{ }
		public LinkEntityToActivity(Activity entity, LinkEntityToActivityParameters parameters) : base(entity, parameters)
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