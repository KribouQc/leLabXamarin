using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lelab.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        void CounterButtonClicked(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new ContPage());
        }

        void TabsButtonClicked(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new TabsPage());
        }


    }
}
