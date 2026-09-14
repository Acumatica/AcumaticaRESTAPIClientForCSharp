using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

using Acumatica.RESTClient.AuthApi;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.DACBrowserApi.Model;

using EndpointSchemaGenerator;

using static Acumatica.RESTClient.DACBrowserApi.DACBrowserApiExtensions;

namespace EndpointModelGenerator
{
    public static class SchemaEnricher
    {
        public static void EnrichSchema(Schema endpointSchema, string endpointMetadata, string? screensMetadata)
        {
            var parsedScreenMetadata = new Dictionary<string, ScreenMetadata>();
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

                DetectDerivedEntities(endpointSchema, parsedEndpointMetadata);
            }
            FillDescriptions(endpointSchema, parsedScreenMetadata, parsedEndpointMetadata);
        }
        private static void DetectDerivedEntities(Schema endpointSchema, Endpoint? parsedEndpointMetadata)
        {
            foreach (var entity in endpointSchema.Entities)
            {
                if (parsedEndpointMetadata.TopLevelEntity?.Any(_ => _.name == entity.Key) ?? false)
                {
                    var topLevelEntityMetadata = parsedEndpointMetadata.TopLevelEntity.First(_ => _.name == entity.Key);

                    // We need to only keep fields that are in the metadata. If we remove any fields, we need to add a parent reference to the entity.
                    foreach (var field in entity.Value.Fields)
                    {
                        if (topLevelEntityMetadata?.Fields != null)
                        {
                            if (!topLevelEntityMetadata.Fields.Any(_ => _.name == field.Name))
                            {
                                endpointSchema.Entities[entity.Key].ParentReference = entity.Key;
                                endpointSchema.Entities[entity.Key].Fields.Remove(field);
                            }
                        }
                    }

                }
                else if (parsedEndpointMetadata.Detail?.Any(_ => _.name == entity.Key) ?? false)
                {
                    var detailEntityMetadata = parsedEndpointMetadata.Detail.First(_ => _.name == entity.Key);

                    // We need to only keep fields that are in the metadata. If we remove any fields, we need to add a parent reference to the entity.
                    foreach (var field in entity.Value.Fields)
                    {
                        if (!detailEntityMetadata.Fields.Any(_ => _.name == field.Name))
                        {
                            endpointSchema.Entities[entity.Key].ParentReference = entity.Key;
                            endpointSchema.Entities[entity.Key].Fields.Remove(field);
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

                    }
                }
                else
                {
                    endpointSchema.Entities[entity.Key].ParentReference = entity.Key;
                    endpointSchema.Entities[entity.Key].Fields.Clear();

                }
            }
        }


        /// <summary>
        /// Matches an HTML anchor and captures its link text.
        /// </summary>
        private static readonly Regex DocumentationLink = new Regex(
            @"<a\s[^>]*>(.*?)</a>",
            RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);

        /// <summary>
        /// Matches the HTML tags that the DAC documentation uses for emphasis. There is no XML
        /// documentation equivalent, so only the tags are dropped and the text is kept.
        /// </summary>
        private static readonly Regex EmphasisTag = new Regex(
            @"</?(?:i|b|em|strong)>",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

        /// <summary>
        /// Normalizes documentation scraped from the DAC browser so that it only contains elements
        /// that C# XML documentation understands.
        /// <para>The DAC documentation is HTML, and the compiler copies unrecognized elements into
        /// the XML doc file verbatim: IntelliSense then shows only their inner text, while a
        /// documentation generator renders them as real HTML. <c>&lt;pre&gt;</c> is the worst of
        /// these, because it is block level and so breaks a sentence around the literal it
        /// wraps.</para>
        /// </summary>
        internal static string? NormalizeDocumentation(string? documentation)
        {
            if (string.IsNullOrEmpty(documentation))
                return documentation;

            // Hyperlinks: neither kind Acumatica emits resolves to anything useful from generated
            // code - DAC browser links are paths on the instance the documentation was scraped
            // from, and the C# language reference links merely wrap the words "true" and "false".
            string result = DocumentationLink.Replace(documentation!, "$1");

            // <pre> marks up a literal value, which is what <c> means in XML documentation.
            result = result.Replace("<pre>", "<c>").Replace("</pre>", "</c>");
            result = result.Replace("<PRE>", "<c>").Replace("</PRE>", "</c>");

            // <p> is spelled <para> in XML documentation.
            result = result.Replace("<p>", "<para>").Replace("</p>", "</para>");
            result = result.Replace("<P>", "<para>").Replace("</P>", "</para>");

            return EmphasisTag.Replace(result, string.Empty);
        }

        private static void FillDescriptions(Schema endpointSchema, Dictionary<string, ScreenMetadata> parsedScreenMetadata, Endpoint? parsedEndpointMetadata)
        {
            foreach (var entity in endpointSchema.Entities)
            {
                var topLevelEntityMetadata = parsedEndpointMetadata.TopLevelEntity.FirstOrDefault(_ => _.name == entity.Key);
                if (topLevelEntityMetadata != null)
                {
                    entity.Value.ScreenID = topLevelEntityMetadata.screen;
                    foreach (var field in entity.Value.Fields)
                    {
                        FillFieldDescription(parsedScreenMetadata, topLevelEntityMetadata.screen, field, topLevelEntityMetadata.Mappings);
                    }
                }
                var detailEntityMetadata = parsedEndpointMetadata.Detail.FirstOrDefault(_ => _.name == entity.Key);
                if (detailEntityMetadata != null)
                {
                    //find corresponding top level entity
                    var childOfAll = endpointSchema.Entities.Where(_ => _.Value.Fields.Any(f => f.Type == $"List<{entity.Key}>"));

                    if (childOfAll.Count() == 1) // we don't want to deal with ambiguous entities
                    {
                        var childOf = childOfAll.First();
                        var parentFieldName = childOf.Value.Fields.Where(f => f.Type == $"List<{entity.Key}>").First().Name;
                        var parentTopLevelEntityMetadata = parsedEndpointMetadata.TopLevelEntity?.FirstOrDefault(_ => _.name == childOf.Key);
                        if (parentTopLevelEntityMetadata != null)
                        {
                            entity.Value.ScreenID = parentTopLevelEntityMetadata.screen;

                            foreach (var field in entity.Value.Fields)
                            {
                                FillFieldDescription(parsedScreenMetadata, parentTopLevelEntityMetadata.screen, field, parentTopLevelEntityMetadata.Mappings.FirstOrDefault(_ => _.field == parentFieldName).Mapping1);
                            }
                        }
                    }
                }
                var linkedEntityMetadata = parsedEndpointMetadata.LinkedEntity?.FirstOrDefault(_ => _.name == entity.Key);
                if (linkedEntityMetadata != null)
                {
                    //find corresponding top level entity
                    var childOfAll = endpointSchema.Entities.Where(_ => _.Value.Fields.Any(f => f.Type == $"{entity.Key}"));

                    if (childOfAll.Count() == 1) // we don't want to deal with ambiguous entities
                    {
                        var childOf = childOfAll.First();
                        var parentFieldName = childOf.Value.Fields.Where(f => f.Type == $"{entity.Key}").First().Name;
                        var parentTopLevelEntityMetadata = parsedEndpointMetadata.TopLevelEntity?.FirstOrDefault(_ => _.name == childOf.Key);
                        if (parentTopLevelEntityMetadata != null)
                        {
                            entity.Value.ScreenID = parentTopLevelEntityMetadata.screen;

                            foreach (var field in entity.Value.Fields)
                            {
                                FillFieldDescription(parsedScreenMetadata, parentTopLevelEntityMetadata.screen, field, parentTopLevelEntityMetadata.Mappings.FirstOrDefault(_ => _.field == parentFieldName)?.Mapping1);
                            }
                        }
                    }
                }
            }
        }

        private static void FillFieldDescription(Dictionary<string, ScreenMetadata> parsedScreenMetadata, string screenID, EntityField field, Mapping[]? mappings)
        {
            var mappingInfo = mappings?.FirstOrDefault(mapping => mapping.@field == field.Name)?.To?.FirstOrDefault();
            if (mappingInfo != null)
            {
                field.DACFieldName = mappingInfo.field;
                field.View = mappingInfo.@object;
                if (parsedScreenMetadata.ContainsKey(screenID))
                {
                    FieldMetadata? val = null;
                    parsedScreenMetadata[screenID].Fields.TryGetValue(field.DACFieldName, out val);
                    if (val != null)
                    {
                        field.DAC = val.DACName;
                    }
                }
            }
        }

        /// <summary>
        /// Caches DAC browser lookups for the lifetime of the process, including the ones that
        /// found nothing.
        /// <para>The same DAC field backs the same entity field in every endpoint version -
        /// <c>Bill.DocType</c> resolves to <c>APInvoice.DocType</c> in all of them - and
        /// <c>GetField</c> takes no endpoint parameter, so two callers asking about one DAC field
        /// issue an identical request and cannot get different answers within a run. Generating
        /// every endpoint asks for 20057 fields of which only 4331 are distinct, so roughly four
        /// out of five requests are repeats.</para>
        /// <para>The site is part of the key because <see cref="AddFieldDescriptions"/> takes the
        /// URL per call, and documentation is specific to the instance it was read from.</para>
        /// </summary>
        /// <remarks>
        /// Not thread safe: the generator enriches one endpoint at a time.
        /// </remarks>
        private static readonly Dictionary<(string Site, string DacNamespace, string DacName, string FieldName), Field?> FieldDescriptionCache
            = new Dictionary<(string, string, string, string), Field?>();

        /// <summary>
        /// Returns the DAC browser description of a field, or <c>null</c> when the DAC browser has
        /// no such field.
        /// </summary>
        /// <remarks>
        /// A "not found" answer is cached too, otherwise a field the browser does not know is
        /// requested again for every entity and every endpoint that references it. Any other
        /// failure - a timeout, a dropped connection, the API login limit - is deliberately left
        /// uncached and allowed to propagate, so that one transient error does not discard the
        /// documentation for every later occurrence of the same field.
        /// </remarks>
        private static Field? GetFieldDescription(ApiClient client, string site, string dacNamespace, string dacName, string fieldName)
        {
            var key = (site, dacNamespace, dacName, fieldName);
            if (FieldDescriptionCache.TryGetValue(key, out Field? cached))
            {
                return cached;
            }

            Field? description;
            try
            {
                description = client.GetField(dacNamespace, dacName, fieldName);
            }
            catch (HttpRequestException e) when (e.StatusCode == HttpStatusCode.NotFound)
            {
                description = null;
            }

            FieldDescriptionCache[key] = description;
            return description;
        }

        public static void AddFieldDescriptions(Schema endpointSchema, string acumaticaUrl, string acumaticaUsername, string acumaticaPassword)
        {
            var client = new ApiClient(acumaticaUrl, ignoreSslErrors: true);
            client.Login(acumaticaUsername, acumaticaPassword);
            try
            {
                foreach (var entity in endpointSchema.Entities)
                {
                    foreach (var field in entity.Value.Fields)
                    {
                        if (!string.IsNullOrEmpty(field.DAC))
                        {
                            try
                            {
                                string dacName = field.DAC.Split('.').Last();
                                string dacNamespace = field.DAC.Substring(0, field.DAC.LastIndexOf('.'));
                                var fieldDescr = GetFieldDescription(client, acumaticaUrl, dacNamespace, dacName, field.DACFieldName!);
                                if (fieldDescr != null)
                                {
                                    field.DisplayName = fieldDescr.DisplayName;
                                    field.SqlType = fieldDescr.SqlType;
                                    field.Summary = NormalizeDocumentation(fieldDescr.Documentation.Summary);
                                    field.Remarks = NormalizeDocumentation(fieldDescr.Documentation.Remarks);
                                    field.IsKey = fieldDescr.IsKey;
                                }
                            }
                            catch { }
                        }
                    }
                }
            }
            finally
            {
                client.Logout();
            }

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
