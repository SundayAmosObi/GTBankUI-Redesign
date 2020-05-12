using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GTBankUI.Data;
using GTBankUI.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GTBankUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutContentsPage : ContentPage
    {
        public FlyoutContentsPage()
        {
            InitializeComponent();
            carouselView.ItemsSource = MonkeyData.Monkeys;
        }

        private void today_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = MonkeyData.Monkeys;
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            var list = (ListView)sender;
            //put your refreshing logic here
            var itemList = MonkeyData.Monkeys.Reverse().ToList();
            MonkeyData.Monkeys.Clear();
            foreach (var s in itemList)
            {
                MonkeyData.Monkeys.Add(s);
            }
            //make sure to end the refresh state
            list.IsRefreshing = false;
        }

        
    }
}