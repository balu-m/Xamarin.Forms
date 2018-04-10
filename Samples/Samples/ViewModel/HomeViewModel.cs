﻿using System.Collections.ObjectModel;
using System.Linq;
using Samples.Model;
using Samples.View;
using Xamarin.Essentials;

namespace Samples.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        private bool alreadyAppeared;

        public HomeViewModel()
        {
            Items = new ObservableCollection<SampleItem>
            {
                new SampleItem("Accelerometer", typeof(AccelerometerPage), "Retrieve acceleration data of the device in three dimensional space."),
                new SampleItem("All Sensors", typeof(AllSensorsPage), "All Sensors on 1 Page"),
                new SampleItem("Battery", typeof(BatteryPage), "Easily detect battery level, source, and state."),
                new SampleItem("Browser", typeof(BrowserPage), "Quickly and easily open a browser to a specific website."),
                new SampleItem("Clipboard", typeof(ClipboardPage), "Quickly and easily use clipboard"),
                new SampleItem("Compass", typeof(CompassPage), "Monitor compass for changes."),
                new SampleItem("Connectivity", typeof(ConnectivityPage), "Check connectivity state and detect changes."),
                new SampleItem("Data Transfer", typeof(DataTransferPage), "Send text and website uris to other apps."),
                new SampleItem("Device Info", typeof(DeviceInfoPage), "Find out about the device with ease."),
                new SampleItem("Email", typeof(EmailPage), "Easily send email messages."),
                new SampleItem("File System", typeof(FileSystemPage), "Easily save files to app data."),
                new SampleItem("Flashlight", typeof(FlashlightPage), "A simple way to turn the flashlight on/off."),
                new SampleItem("Geocoding", typeof(GeocodingPage), "Easily geocode and reverse geocoding."),
                new SampleItem("Geolocation", typeof(GeolocationPage), "Quickly get the current location."),
                new SampleItem("Gyroscope", typeof(GyroscopePage), "Retrieve  rotation around the device's three primary axes."),
                new SampleItem("Magnetometer", typeof(MagnetometerPage), "Detect device's orientation relative to Earth's magnetic field."),
                new SampleItem("Phone Dialer", typeof(PhoneDialerPage), "Easily open phone dialer."),
                new SampleItem("Preferences", typeof(PreferencesPage), "Quickly and easily add persistent preferences."),
                new SampleItem("Screen Lock", typeof(ScreenLockPage), "Keep the device screen awake."),
                new SampleItem("Secure Storage", typeof(SecureStoragePage), "Securely store data."),
                new SampleItem("SMS", typeof(SMSPage), "Easily send SMS messages."),
                new SampleItem("Vibration", typeof(VibrationPage), "Quickly and easily make the device vibrate."),
            };
        }

        public ObservableCollection<SampleItem> Items { get; }

        public override void OnAppearing()
        {
            base.OnAppearing();

            if (!alreadyAppeared)
            {
                alreadyAppeared = true;

                if (VersionTracking.IsFirstLaunchEver)
                {
                    DisplayAlert("Welcome to the Samples!");
                }
                else if (VersionTracking.IsFirstLaunchForCurrentVersion)
                {
                    var count = VersionTracking.VersionHistory.Count();
                    DisplayAlert($"Welcome to the NEW Samples! You have tried {count} versions.");
                }
            }
        }
    }
}
