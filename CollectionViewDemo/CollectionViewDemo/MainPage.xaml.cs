using CollectionViewDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace CollectionViewDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           // On<iOS>().SetUseSafeArea(true);
            BindingContext = this;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new MainPageViewModels();
        }       

       
    }
}
