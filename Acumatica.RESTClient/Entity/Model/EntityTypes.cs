using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Acumatica.RESTClient.Model
{
    public class LinkedEntity
    {
        public Entity Value;
        public Type Type;
        public string Name;
        public LinkedEntity(Type type, Entity value, string name)
        {
            Value = value;
            Type = type;
            Name = name;
        }
    }
    public class DetailEntity
    {
        public IEnumerable<Entity> Details;
        public string Name;
        public Type Type;
        public DetailEntity(Type type, IEnumerable details, string name)
        {
            Details = details.Cast<Entity>();
            Name = name;
            Type = type;
        }
    }
}
