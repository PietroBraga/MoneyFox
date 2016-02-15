﻿using System;
using Windows.UI.Xaml;
using MoneyManager.Windows.Dialogs;

namespace MoneyManager.Windows.Views
{
    public sealed partial class StatisticCategorySummaryPage
    {
        public StatisticCategorySummaryPage()
        {
            InitializeComponent();
        }

        private async void SetDate(object sender, RoutedEventArgs e)
        {
            await new SelectDateRangeDialog().ShowAsync();
        }
    }
}