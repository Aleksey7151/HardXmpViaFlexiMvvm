using UIKit;

namespace VacationsTracker.iOS.Theme.Light
{
    internal class LightAppThemeColors : AppThemeColors
    {
        public override UIColor Primary { get; } = FromHex("#892548");

        public override UIColor Secondary { get; } = FromHex("#892548");

        public override UIColor ContentBackground { get; } = FromHex("#892548");

        public override UIColor TextPrimary { get; } = FromHex("#892548");

        public override UIColor TextSecondary { get; } = UIColor.White;

        public override UIColor Hint { get; } = FromHex("#892548");
    }
}