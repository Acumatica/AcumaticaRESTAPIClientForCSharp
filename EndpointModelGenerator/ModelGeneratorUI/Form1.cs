using EndpointSchemaGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			label5.Text = ((OpenFileDialog)sender).FileName;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox2.Text = "Generating...";
			SchemaGenerator.Generate(label5.Text, textBox1.Text);
			textBox2.Text += "Done!";
			button1.Enabled = false;
			button2.Enabled = false;
		}
	}
}
