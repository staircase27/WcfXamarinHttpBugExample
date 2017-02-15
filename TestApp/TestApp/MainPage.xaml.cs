using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WcfClient;
using Xamarin.Forms;

namespace TestApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => true;
            InitializeComponent();
		}


	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        var client = new Client(Switch.IsToggled);
	        client.Open().Wait();
	        try
	        {
	            LogLabel.Text = $@"Got ""{client.SayHello(NameEntry.Text).Result}"" on {client.Url}

{LogLabel.Text}";
	        }
	        catch (Exception exception)
	        {
	            LogLabel.Text =
	                $@"Exception for name - ""{NameEntry.Text}"" on client - {client.Url}:
{exception}

{LogLabel.Text}";
	        }
	    }
	}
}
