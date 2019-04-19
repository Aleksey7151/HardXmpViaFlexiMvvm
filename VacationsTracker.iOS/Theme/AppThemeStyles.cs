using Cirrious.FluentLayouts.Touch;
using UIKit;

namespace VacationsTracker.iOS.Theme
{
    internal static class AppThemeStyles
    {
        public static UILabel SetTitle1Style(this UILabel label, string text = null)
        {
            label.Font = AppTheme.Current.Fonts.Title;
            label.TextColor = AppTheme.Current.Colors.TextPrimary;
            label.Lines = 0;
            label.Text = text;

            return label;
        }

        public static UIButton SetButton1Style(this UIButton button, string title = null)
        {
            button.Font = AppTheme.Current.Fonts.Button1;
            button.SetTitle(title, UIControlState.Normal);
            button.SetTitleColor(AppTheme.Current.Colors.TextSecondary, UIControlState.Normal);
            button.Layer.CornerRadius = 10;
            button.Layer.MasksToBounds = true;
            button.AddConstraints(button.Height().EqualTo(AppTheme.Current.Dimens.ButtonDefaultHeight));
            button.BackgroundColor = AppTheme.Current.Colors.Primary;

            return button;
        }
    }
}