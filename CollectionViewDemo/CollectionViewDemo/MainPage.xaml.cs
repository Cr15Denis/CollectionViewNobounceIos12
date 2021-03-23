using CollectionViewDemo.Models;
using CollectionViewDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new MainPageViewModels();
        }

        private void MyCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            var products = e.CurrentSelection;            
            string msg = String.Empty;            
            msg = "Producto Seleccionado: \n";
            for (int i = 0; i < products.Count; i++)
            {
                var product = products[i] as Product;
                msg += $"{product.Name} Q{product.Price}";

            }
            if (e.CurrentSelection.Count == 0)            
                return;
                var item = e.CurrentSelection[0];
                //perform action on selection or navigate to details view

                ((CollectionView)sender).SelectedItem = null;
                // MyCollectionView.SelectedItem = null;
                DisplayAlert("Producto", msg, "OK");
               



        }

       
    }
}
