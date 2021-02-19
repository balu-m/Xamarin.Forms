﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Platform;

namespace Sample
{
	public class MyApp : IApp
	{
		public MyApp()
		{
			Platform.Init();
		}

		public IWindow GetWindowFor(Dictionary<string, string> state) => throw new NotImplementedException();

		public IServiceProvider Services => throw new NotImplementedException();

		public IHandlersContext Context => throw new NotImplementedException();

		public IView CreateView()
		{
			var verticalStack = new VerticalStackLayout() { Spacing = 5, BackgroundColor = Color.AntiqueWhite };
			var horizontalStack = new HorizontalStackLayout() { Spacing = 2, BackgroundColor = Color.CornflowerBlue };

			var label = new Label { Text = "This will disappear in ~5 seconds", BackgroundColor = Color.Fuchsia };
			label.Margin = new Thickness(15, 10, 20, 15);

			verticalStack.Add(label);

			var button = new Button() { Text = "A Button", Width = 200 };
			var button2 = new Button()
			{
				TextColor = Color.Green,
				Text = "Hello I'm a button",
				BackgroundColor = Color.Purple,
				Margin = new Thickness(12)
			};

			horizontalStack.Add(button);
			horizontalStack.Add(button2);
			horizontalStack.Add(new Label { Text = "And these buttons are in a HorizontalStackLayout" });

			verticalStack.Add(horizontalStack);
			verticalStack.Add(new Slider());

			return verticalStack;
		}
	}
}