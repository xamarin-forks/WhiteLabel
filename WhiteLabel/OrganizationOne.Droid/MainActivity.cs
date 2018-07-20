﻿using Android.App;
using Android.Content.PM;
using AppBase.Droid;
using OrganizationOne.Core;

namespace Organization.Droid.Droid
{
    [Activity(Label = "Organization.Droid", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MainActivityBase
    {
        public override AppBase.Core.ApplicationBase LoadCustomApplication()
        {
            return new App(new OrganizationOne.Droid.AndroidInitializer());
        }
    }
}

