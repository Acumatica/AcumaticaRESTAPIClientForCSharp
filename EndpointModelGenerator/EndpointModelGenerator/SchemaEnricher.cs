using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

using EndpointSchemaGenerator;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.AuthApi;
using static Acumatica.RESTClient.DACBrowserApi.DACBrowserApiExtensions;

namespace EndpointModelGenerator
{
    public static class SchemaEnricher
    {
        public static void EnrichSchema(Schema endpointSchema, string endpointMetadata, string? screensMetadata)
        {
           var parsedScreenMetadata =  new Dictionary<string, ScreenMetadata> ();
            if (!String.IsNullOrEmpty(screensMetadata))
            {
                foreach (var line in screensMetadata.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries))
                {
                    var parts = line.Split(',');
                    if (!parsedScreenMetadata.ContainsKey(parts[0]))
                    {
                        parsedScreenMetadata.Add(parts[0], new ScreenMetadata());
                    }

                    parsedScreenMetadata[parts[0]].Fields.TryAdd(parts[1], new FieldMetadata() { ViewName = parts[2], DACName = parts[3] });
                }
            }
            XmlSerializer ser = new XmlSerializer(typeof(Endpoint));
            Endpoint? parsedEndpointMetadata;
            using (XmlReader reader = XmlReader.Create(new StringReader(endpointMetadata)))
            {
                parsedEndpointMetadata = (Endpoint)ser.Deserialize(reader);
            }
            if (parsedEndpointMetadata == null)
            {
                return;
            }
            if (parsedEndpointMetadata.ExtendsEndpoint != null)
            {
                endpointSchema.BaseEndpoint = $"{parsedEndpointMetadata.ExtendsEndpoint.name}_{parsedEndpointMetadata.ExtendsEndpoint.version}";
               
            }
            foreach (var entity in endpointSchema.Entities)
            {
                if (parsedEndpointMetadata.TopLevelEntity?.Any(_ => _.name == entity.Key) ?? false)
                {
                    var topLevelEntityMetadata = parsedEndpointMetadata.TopLevelEntity.First(_ => _.name == entity.Key);
                    entity.Value.ScreenID = topLevelEntityMetadata.screen;
                    // We need to only keep fields that are in the metadata. If we remove any fields, we need to add a parent reference to the entity.
                    foreach (var field in entity.Value.Fields)
                    {
                        if (!topLevelEntityMetadata.Fields.Any(_ => _.name == field.Name))
                        {
                            endpointSchema.Entities[entity.Key].ParentReference = entity.Key;
                            endpointSchema.Entities[entity.Key].Fields.Remove(field);
                        }
                        else
                        {
                            // fill mappings and view name here from metadata
                            var mappingInfo = topLevelEntityMetadata.Mappings.FirstOrDefault(mapping => mapping.@field == field.Name)?.To?.FirstOrDefault();
                            if (mappingInfo != null)
                            {
                                field.DACFieldName = mappingInfo.field;
                                field.View = mappingInfo.@object;
                                if (parsedScreenMetadata.ContainsKey(topLevelEntityMetadata.screen))
                                {
                                    FieldMetadata? val = null;
                                    parsedScreenMetadata[topLevelEntityMetadata.screen].Fields.TryGetValue(field.DACFieldName, out val);
                                    if (val != null)
                                    {
                                        field.DAC = val.DACName;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (parsedEndpointMetadata.Detail?.Any(_ => _.name == entity.Key) ?? false)
                {

                    var detailEntityMetadata = parsedEndpointMetadata.Detail.First(_ => _.name == entity.Key);

                    //find corresponding top level entity
                    var childOfAll = endpointSchema.Entities.Where(_ => _.Value.Fields.Any(f => f.Type == $"List<{entity.Key}>"));
                    KeyValuePair<string, EntityDefinition>? childOf = null;
                    string? parentFieldName = null;
                    Mapping? mappingInfo = null;
                    EndpointTopLevelEntity? topLevelEntityMetadata = null;
                    if (childOfAll.Count() == 1)
                    {
                        childOf = childOfAll.First();
                        parentFieldName = childOfAll.First().Value.Fields.Where(f => f.Type == $"List<{entity.Key}>").First().Name;
                        mappingInfo = parsedEndpointMetadata.TopLevelEntity?.FirstOrDefault(_ => _.name == childOf?.Key)?.Mappings?.First(_ => _.field == parentFieldName);
                        topLevelEntityMetadata = parsedEndpointMetadata.TopLevelEntity?.FirstOrDefault(_ => _.name == childOf?.Key);
                    }
                    else
                    { 
                    }
                    
                    // We need to only keep fields that are in the metadata. If we remove any fields, we need to add a parent reference to the entity.
                    foreach (var field in entity.Value.Fields)
                    {
                        if (!detailEntityMetadata.Fields.Any(_ => _.name == field.Name))
                        {
                            endpointSchema.Entities[entity.Key].ParentReference = entity.Key;
                            endpointSchema.Entities[entity.Key].Fields.Remove(field);
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(childOf?.Key))
                            {
                                // fill mappings and view name here from metadata
                                if (mappingInfo != null)
                                {
                                    var fieldMapping = mappingInfo.Mapping1.FirstOrDefault(_ => _.field == field.Name)?.To?.FirstOrDefault();
                                    field.DACFieldName = fieldMapping?.field;
                                    field.View = fieldMapping?.@object;
                                    if (parsedScreenMetadata.ContainsKey(topLevelEntityMetadata!.screen) && (!string.IsNullOrEmpty(field.DACFieldName)))
                                    {
                                        FieldMetadata? val = null;
                                        parsedScreenMetadata[topLevelEntityMetadata.screen].Fields.TryGetValue(field.DACFieldName, out val);
                                        if (val != null)
                                        {
                                            field.DAC = val.DACName;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (parsedEndpointMetadata.LinkedEntity?.Any(_ => _.name == entity.Key) ?? false)
                {
                    // We need to only keep fields that are in the metadata. If we remove any fields, we need to add a parent reference to the entity.
                    foreach (var field in entity.Value.Fields)
                    {
                        if (!parsedEndpointMetadata.LinkedEntity.First(_ => _.name == entity.Key).Fields.Any(_ => _.name == field.Name))
                        {
                            endpointSchema.Entities[entity.Key].ParentReference = entity.Key;
                            endpointSchema.Entities[entity.Key].Fields.Remove(field);
                        }
                        else
                        {
                            // TODO: fill mappings and view name here from metadata
                        }
                    }
                }
                else
                {
                    endpointSchema.Entities[entity.Key].ParentReference = entity.Key;
                    endpointSchema.Entities[entity.Key].Fields.Clear();
                }
            }
        }

        public static void AddFieldDescriptions(Schema endpointSchema, string acumaticaUrl, string acumaticaUsername, string acumaticaPassword)
        {
            var client = new ApiClient(acumaticaUrl, ignoreSslErrors: true);
            client.Login(acumaticaUsername, acumaticaPassword);
            try { 
                foreach (var entity in endpointSchema.Entities)
                {
                    foreach(var field in entity.Value.Fields)
                    {
                        if (!string.IsNullOrEmpty(field.DAC))
                        {
                            try
                            {
                                string dacName = field.DAC.Split('.').Last();
                                string dacNamespace = field.DAC.Substring(0, field.DAC.LastIndexOf('.'));
                                var fieldDescr = client.GetField(dacNamespace, dacName, field.DACFieldName!);
                                field.DisplayName = fieldDescr.DisplayName;
                                field.SqlType = fieldDescr.SqlType;
                                field.Summary = fieldDescr.Documentation.Summary;
                                field.Remarks = fieldDescr.Documentation.Remarks;
                                field.IsKey = fieldDescr.IsKey;
                            }
                            catch { }
                        }
                    }
                }
            }
            finally { 
                client.Logout(); }
            
        }
    }

    internal class ScreenMetadata
    {
        public Dictionary<string, FieldMetadata> Fields;

        public ScreenMetadata()
        {
            Fields = new Dictionary<string, FieldMetadata>();
        }
    }

    internal class FieldMetadata
    {
        public string? ViewName;
        public string? DACName;

    }
}
