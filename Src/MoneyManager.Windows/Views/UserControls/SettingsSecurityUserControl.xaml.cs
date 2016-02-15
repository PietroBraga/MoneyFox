﻿using MoneyManager.Core.ViewModels;
using MvvmCross.Platform;

namespace MoneyManager.Windows.Views.UserControls
{
    public sealed partial class SettingsSecurityUserControl
    {
        public SettingsSecurityUserControl()
        {
            InitializeComponent();
            DataContext = Mvx.Resolve<SettingsSecurityViewModel>();
        }
    }
}