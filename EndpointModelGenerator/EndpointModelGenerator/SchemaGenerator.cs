using System;
using System.IO;
using System.Linq;

namespace EndpointSchemaGenerator
{
    public partial class SchemaGenerator
    {
        public static void WriteCSharp(string outputPath, 
            Schema schema, 
            Action<string> writeLogDelegate, 
            string endpointNamespace, 
            string csprojPath, 
            string additionalPath = "")
        {
            string modelLocalPath = additionalPath + "Model\\";
            string actionsLocalPath = modelLocalPath + "Actions\\";
            string actionParametersLocalPath = modelLocalPath + "ActionParameters\\";
            string apiLocalPath = additionalPath + "Api\\";

            string modelFilesDirectory = outputPath + modelLocalPath;
            string modelActionsFilesDirectory = outputPath + actionsLocalPath;
            string modelParametersFilesDirectory = outputPath + actionParametersLocalPath;
            string apiFilesDirectory = outputPath + apiLocalPath;

            RegenerateDirectories(outputPath, modelFilesDirectory, modelActionsFilesDirectory, modelParametersFilesDirectory, apiFilesDirectory);

            WriteCsProj(csprojPath);

            WriteEntities(schema, writeLogDelegate, endpointNamespace, modelLocalPath, modelFilesDirectory);
            WriteBaseApi(schema, writeLogDelegate, endpointNamespace, apiLocalPath, apiFilesDirectory);
            WriteApis(schema, writeLogDelegate, endpointNamespace, apiLocalPath, apiFilesDirectory);
            WriteActions(schema, writeLogDelegate, endpointNamespace, actionsLocalPath, actionParametersLocalPath, modelActionsFilesDirectory, modelParametersFilesDirectory);

            writeLogDelegate.Invoke("Done!");
        }

        private static void WriteCsProj(string csprojPath)
        {
            StreamWriter writer = new StreamWriter(csprojPath);
            writer.Write(Templates.ProjectTemplate);
            writer.Close();
        }

        private static void WriteActions(Schema schema, 
            Action<string> writeLogDelegate, 
            string endpointNamespace, 
            string actionsLocalPath, 
            string actionParametersLocalPath, 
            string modelActionsFilesDirectory, 
            string modelParametersFilesDirectory)
        {
            foreach (var action in schema.Actions)
            {
                string filename = action.Key + ".cs";
                if (schema.Parameters.ContainsKey(action.Key))
                {
                    StreamWriter writer = new StreamWriter(modelActionsFilesDirectory + filename);
              
                    string content = "";
                    foreach (var parameter in schema.Parameters[action.Key])
                    {
                        content += String.Format(Templates.InActionParameterTemplate, parameter.Key, parameter.Value);
                    }
                    string result = String.Format(Templates.ActionWithParametersTemplate, endpointNamespace, action.Key, action.Value, content);

                    writer.Write(Templates.ActionUsingsTemplate + result);
                    writer.Close();

                    string paramFileName = action.Key + "Parameters.cs";
                    writer = new StreamWriter(modelParametersFilesDirectory + paramFileName);
           

                    content = "";
                    foreach (var parameter in schema.Parameters[action.Key])
                    {
                        content += "\r\n" + String.Format(Templates.ParameterTemplate, parameter.Key, parameter.Value);
                    }
                    result = String.Format(Templates.ActionParametersTemplate, endpointNamespace, action.Key, content);
                    writeLogDelegate.Invoke("ActionsWithParameters/" + action.Key);
                    writer.Write(result);
                    writer.Close();
                }
                else
                {
                    StreamWriter writer = new StreamWriter(modelActionsFilesDirectory + filename);
                   
                    string result = String.Format(Templates.ActionTemplate, endpointNamespace, action.Key, action.Value);
                    writeLogDelegate.Invoke("Actions/" + action.Key);
                    writer.Write(Templates.ActionUsingsTemplate + result);
                    writer.Close();
                }
            }
        }
        private static void WriteBaseApi(Schema schema, 
            Action<string> writeLogDelegate, 
            string endpointNamespace, 
            string apiLocalPath, 
            string apiFilesDirectory)
        {
            string filename = "BaseEndpointApi.cs";
            StreamWriter writer = new StreamWriter(apiFilesDirectory + filename);

            string result = String.Format(Templates.BaseEndpointApiTemplate, endpointNamespace, schema.Info.Title);
            writeLogDelegate.Invoke("BaseEndpointApi");
            writer.Write(result);
            writer.Close();
        }
        private static void WriteApis(Schema schema, 
            Action<string> writeLogDelegate, 
            string endpointNamespace, 
            string apiLocalPath, 
            string apiFilesDirectory)
        {
			foreach (var entity in schema.TopLevelEntities)
			{
				string filename = entity + "Api.cs";
				StreamWriter writer = new StreamWriter(apiFilesDirectory + filename);

				string result = String.Format(Templates.ApiTemplate, endpointNamespace, entity);
				writeLogDelegate.Invoke(entity + "Api");
				writer.Write(result);
				writer.Close();
			}
		}

        private static void WriteEntities(Schema schema, 
            Action<string> writeLogDelegate, 
            string endpointNamespace, 
            string modelLocalPath, 
            string modelFilesDirectory)
        {
            foreach (var entity in schema.Entities)
            {
                string filename = entity.Key + ".cs";
                StreamWriter writer = new StreamWriter(modelFilesDirectory + filename);
                string body = "";
                foreach (var field in entity.Value)
                {
                    body += string.Format(Templates.FieldTemplate, field.Key, field.Value);
                }
                string result = String.Format(Templates.EntityTemplate, endpointNamespace, entity.Key, body, schema.Info.Version);
                writeLogDelegate.Invoke(entity.Key);
                writer.Write(Templates.EntityUsingsTemplate + result);
                writer.Close();
            }
        }

        private static void RegenerateDirectories(string outputPath, 
            string modelFilesDirectory, 
            string modelActionsFilesDirectory, 
            string modelParametersFilesDirectory, 
            string apiFilesDirectory)
        {
            Directory.CreateDirectory(outputPath);
            try
            {
                Directory.Delete(modelFilesDirectory, true);
            }
            catch { }
            Directory.CreateDirectory(modelFilesDirectory);
            Directory.CreateDirectory(modelActionsFilesDirectory);
            Directory.CreateDirectory(modelParametersFilesDirectory);
            try
            {
                Directory.Delete(apiFilesDirectory, true);
            }
            catch { }
            Directory.CreateDirectory(apiFilesDirectory);
        }
    }
}
