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
		string endpointName;
		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{ 
			pathToProject = ((OpenFileDialog)sender).FileName;
			label5.Text = pathToProject;
			directoryPath = Directory.GetParent(pathToProject).ToString();
			textBox4.Text = directoryPath;

			endpointName = pathToProject.Replace(directoryPath, "").Replace(".csproj", "").Replace("Acumatica.", "").Replace("\\", "");
			textBox3.Text = endpointName;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			button1.Enabled = false;
			button2.Enabled = false;

			textBox2.Text = "Generating...";

			Schema schema = JsonSchemaParser.ComposeEndpointSchema(textBox1.Text);
			textBox2.Text += "\r\nEnpoint schema - OK";

			textBox2.Text += "\n\rWriting code...";

			SchemaGenerator.WriteCSharp(pathToProject, directoryPath, endpointName, textBox1.Text, (_) => textBox2.Text += ("\n\r" + _));
		}
	}
}
