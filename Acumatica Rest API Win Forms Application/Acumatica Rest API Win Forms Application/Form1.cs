using Acumatica.RESTClient.AuthApi;
using Acumatica.RESTClient.Client;

namespace Acumatica_Rest_API_Win_Forms_Application
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void testConnectionButton_Click(object sender, EventArgs e)
		{
			connectionStatusLabel.Text = "Testing...";
			ApiClient client = new ApiClient(urlBox.Text);
			try
			{
				client.Login(userBox.Text, passwordBox.Text, tenantBox.Text);
				connectionStatusLabel.Text = "Connection successful";
			}
			catch (Exception ex)
			{
				connectionStatusLabel.Text = "Error: " + ex.Message;
			}
			finally
			{
				client.TryLogout();
			}
		}
	}
}