﻿using Xamarin.Platform.Handlers;

namespace Xamarin.Forms
{
	public static class FormsHandlers
	{
		// This is used to register the handler version against the xplat code so that the handler version will be used
		// when running a full Xamarin.Forms application. This lets us test the handler code inside the Control Gallery
		// And other scenarios
		public static void InitHandlers()
		{
			Platform.Registrar.Handlers.Register(typeof(WebView), typeof(WebViewHandler));
		}
	}
}