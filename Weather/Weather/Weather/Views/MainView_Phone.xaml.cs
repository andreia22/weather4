﻿using Weather.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView_Phone : ContentPage
    {
        public MainView_Phone()
        {            
            BindingContext = Resolver.Resolve<MainViewModel>();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is MainViewModel viewModel)
            {
                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    await viewModel.LoadData();
                });
            }
        }
    }
}