using EndpointSchemaGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EndpointSchemaGenerator;
using static EndpointSchemaGenerator.SchemaGenerator;

namespace ModelGeneratorUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
		string pathToProject;
		string directoryPath;
		string additionalPath;
		string endpointName;
		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			pathToProject = ((OpenFileDialog)sender).FileName;
			label5.Text = pathToProject;
			directoryPath = Directory.GetParent(pathToProject).ToString();
			additionalPath = "";
			endpointName = pathToProject.Replace(directoryPath, "").Replace(".csproj", "").Replace("Acumatica.", "").Replace("\\", "");
			if (endpointName == "RESTClient")
			{
				endpointName = "Default_20.200.001";
				additionalPath += endpointName + "\\";
			}
			textBox3.Text = endpointName;
			textBox4.Text = directoryPath;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			button1.Enabled = false;
			button2.Enabled = false;

			textBox2.Text = "Generating...";
			Schema schema;
			try
			{
				schema = JsonSchemaParser.ComposeEndpointSchema(textBox1.Text);
			}
			catch (Exception ex)
			{
				textBox2.Text+= "\r\nError reading endpoint";
				textBox2.Text += "\r\n" + ex.Message;
				button1.Enabled = true;
				button2.Enabled = true;
				return;
			}
			textBox2.Text += "\r\nEnpoint schema - OK";

			textBox2.Text += "\r\nWriting code...";

			SchemaGenerator.WriteCSharp(directoryPath + "\\", schema, (_) => textBox2.Text += ("\r\n" + _), "Acumatica." + endpointName.Replace(".", "_"), pathToProject, additionalPath);
		}
	}
}
