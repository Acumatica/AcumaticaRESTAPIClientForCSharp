using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Acumatica.RESTClient.ODataApi
{
    [XmlRoot("Schema", Namespace = "http://schemas.microsoft.com/ado/2009/11/edm", IsNullable = false)]
    public class Metadata
    {
        [XmlElement(ElementName = "EntityType", Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
        public EntityType[] EntityType { get; set; }
    }
    [XmlRoot(ElementName = "EntityType", Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
    public class EntityType
    {
        [XmlElement(ElementName = "Key", Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
        public Key Key { get; set; }
        [XmlElement(ElementName = "Property", Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
        public Property[] Property { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "Key", Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
    public class Key
    {
        [XmlElement(ElementName = "PropertyRef", Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
        public PropertyRef PropertyRef { get; set; }
    }

    [XmlRoot(ElementName = "PropertyRef", Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
    public class PropertyRef
    {
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "Property", Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
    public class Property
    {
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
    }

}
