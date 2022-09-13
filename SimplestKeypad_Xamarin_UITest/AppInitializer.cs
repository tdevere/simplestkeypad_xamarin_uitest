using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SimplestKeypad_Xamarin_UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile(@"C:\Users\tdevere.NORTHAMERICA\AppData\Local\Xamarin\Mono for Android\Archives\2022-09-12\SimplestKeypad.Droid 9-12-22 7.11 PM.apkarchive\SimplestKeypad.Droid.apk")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}