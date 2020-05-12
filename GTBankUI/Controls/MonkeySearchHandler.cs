using GTBankUI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace GTBankUI.Controls
{
    public class MonkeySearchHandler : SearchHandler 
    {
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = MonkeyData.Monkeys
                    .Where(monkey => monkey.Name.ToLower().Contains(newValue.ToLower()))
                    .ToList();
            }
        }
    }
}
