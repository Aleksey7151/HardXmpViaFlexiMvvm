using Cirrious.FluentLayouts.Touch;
using FlexiMvvm.Views;
using UIKit;
using VacationsTracker.iOS.Theme;

namespace VacationsTracker.iOS.Views.Login
{
    internal class LoginView : ScrollableLayoutView
    {
        private UILabel TitleLabel { get; set; }

        public UIButton LoginButton { get; private set; }

        protected override void SetupSubviews()
        {
            base.SetupSubviews();

            BackgroundColor = UIColor.White;

            //TODO Move to strings
            TitleLabel = new UILabel().SetTitle1Style("Login Page");
            LoginButton = new UIButton(UIButtonType.System).SetButton1Style("Login");
        }

        protected override void SetupLayout()
        {
            base.SetupLayout();

            ContentView
                .AddLayoutSubview(TitleLabel)
                .AddLayoutSubview(LoginButton);
        }

        protected override void SetupLayoutConstraints()
        {
            base.SetupLayoutConstraints();

            this.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            ContentView.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            ContentView.AddConstraints(
                TitleLabel.AtLeftOf(ContentView, AppTheme.Current.Dimens.Inset2x),
                TitleLabel.AtTopOf(ContentView, AppTheme.Current.Dimens.Inset4x),
                TitleLabel.AtRightOf(ContentView, AppTheme.Current.Dimens.Inset2x));

            ContentView.AddConstraints(
                LoginButton.AtLeftOf(ContentView, AppTheme.Current.Dimens.Inset2x),
                LoginButton.Below(TitleLabel, AppTheme.Current.Dimens.Inset4x),
                LoginButton.AtRightOf(ContentView, AppTheme.Current.Dimens.Inset2x),
                LoginButton.AtBottomOf(ContentView, AppTheme.Current.Dimens.Inset2x));
        }
    }
}