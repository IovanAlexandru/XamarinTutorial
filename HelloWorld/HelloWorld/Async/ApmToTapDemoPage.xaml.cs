﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Async
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApmToTapDemoPage : ContentPage
	{
		public ApmToTapDemoPage ()
		{
			InitializeComponent ();
		}

	    private async void OnLoadButtonClicked(object sender, EventArgs e)
	    {
	        try
	        {
	            Stream stream = await GetStreamAsync("https://developer.xamarin.com/demo/IMG_1996.JPG");
	            image.Source = ImageSource.FromStream(() => stream);
	        }
	        catch (Exception ex)
	        {
	            errorLabel.Text = ex.Message;
	        }
	    }

	    private async Task<Stream> GetStreamAsync(string url)
	    {
	        TaskFactory factory = new TaskFactory();
            WebRequest request = WebRequest.Create(url);
	        WebResponse response = await factory.FromAsync(request.BeginGetResponse, request.EndGetResponse, null);
	        return response.GetResponseStream();
	    }
	}
}