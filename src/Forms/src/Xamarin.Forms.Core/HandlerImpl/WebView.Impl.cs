﻿using Xamarin.Platform;

namespace Xamarin.Forms
{
	public partial class WebView : IWebView
	{
		WebViewSource2 IWebView.Source { get; set; }
	}
}