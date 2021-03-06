﻿using Android.Content;
using FlexiMvvm;
using VacationsTracker.Core.Navigation;
using VacationsTracker.Core.Presentation.ViewModels;
using VacationsTracker.Droid.Views.Login;
using VacationsTracker.Droid.Views.SplashScreen;

namespace VacationsTracker.Droid.Navigation
{
    internal class NavigationService : FlexiMvvm.Navigation.NavigationService, INavigationService
    {
        public void NavigateToLogin(EntryViewModel fromViewModel)
        {
            var splashScreenActivity = GetActivity<SplashScreenActivity, EntryViewModel>(fromViewModel);
            var loginIntent = new Intent(splashScreenActivity, typeof(LoginActivity));
            splashScreenActivity.NotNull().StartActivity(loginIntent);
        }
    }
}