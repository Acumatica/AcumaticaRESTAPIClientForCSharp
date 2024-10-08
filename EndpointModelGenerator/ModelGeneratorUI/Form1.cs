using EndpointSchemaGenerator;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace ModelGeneratorUI
{
    public partial class Form1 : Form
    {
        string pathToProject;
        string directoryPath;
        string additionalPath;
        string endpointName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SelectProjectButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pathToProject = ((OpenFileDialog)sender).FileName;
            PathTextBox.Text = pathToProject;
            directoryPath = Directory.GetParent(pathToProject).ToString();
            additionalPath = "";
            endpointName = pathToProject.Replace(directoryPath, "").Replace(".csproj", "").Replace("Acumatica.", "").Replace("\\", "");
            if (endpointName == "RESTClient")
            {
                endpointName = "Default_20.200.001";
                additionalPath += endpointName + "\\";
            }
            EndpointTextBox.Text = endpointName;
            PathToModelTextBox.Text = directoryPath;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            SelectProjectButton.Enabled = false;
            GenerateButton.Enabled = false;
            JsonSchemaParser.GenerateArraysInstedOfLists = ArrayCollectionsCheckbox.Checked;

            LogTextBox.Text = "Generating...";
            Schema schema;
            try
            {
                schema = JsonSchemaParser.ComposeEndpointSchema(SchemaTextBox.Text);
            }
            catch (Exception ex)
            {
                LogTextBox.Text += "\r\nError reading endpoint";
                LogTextBox.Text += "\r\n" + ex.Message;
                GenerateButton.Enabled = true;
                SelectProjectButton.Enabled = true;
                return;
            }
            LogTextBox.Text += "\r\nEnpoint schema - OK";

            LogTextBox.Text += "\r\nWriting code...";

            SchemaGenerator.WriteCSharp(directoryPath + "\\", 
                endpointName, 
                schema,
                (_) => LogTextBox.Text += ("\r\n" + _), 
                "Acumatica." + endpointName.Replace(".", "_"));
        }
    }
}
