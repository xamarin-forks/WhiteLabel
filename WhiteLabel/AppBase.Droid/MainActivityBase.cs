﻿using Android.OS;
using AppBase.Core;
using Prism;

namespace AppBase.Droid
{
    public partial class MainActivityBase : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        public void OnCreate(Bundle bundle, IPlatformInitializer platformInitializer)
        {

        }

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new Core.ApplicationBase(new AndroidInitializer()));
        }
    }
}
