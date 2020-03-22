using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class LinkEntityToEmail : EntityActionWithParameters<Email, LinkEntityToEmailParameters>
	{
		public LinkEntityToEmail() : base()
		{ }
		public LinkEntityToEmail(Email entity, LinkEntityToEmailParameters parameters) : base(entity, parameters)
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