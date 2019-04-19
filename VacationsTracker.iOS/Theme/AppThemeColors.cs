using System;
using FlexiMvvm;
using UIKit;

namespace VacationsTracker.iOS.Theme
{
    internal abstract class AppThemeColors
    {
        public abstract UIColor Primary { get; }

        public abstract UIColor Secondary { get; }

        public abstract UIColor ContentBackground { get; }

        public abstract UIColor TextPrimary { get; }

        public abstract UIColor TextSecondary { get; }

        public abstract UIColor Hint { get; }

        protected static UIColor FromHex(string value, float alpha = 1.0f)
        {
            alpha = (alpha < 0.0f) ? 0.0f : (alpha > 1.0f) ? 1.0f : alpha;

            var hexValue = value.Replace("#", string.Empty);
            float red, green, blue;

            switch (hexValue.Length)
            {
                case 3: // #RGB
                    red = Convert.ToInt32(string.Format("{0}{0}", hexValue.Substring(0, 1)), 16) / 255f;
                    green = Convert.ToInt32(string.Format("{0}{0}", hexValue.Substring(1, 1)), 16) / 255f;
                    blue = Convert.ToInt32(string.Format("{0}{0}", hexValue.Substring(2, 1)), 16) / 255f;
                    return UIColor.FromRGBA(red, green, blue, alpha).NotNull();
                case 6: // #RRGGBB
                    red = Convert.ToInt32(hexValue.Substring(0, 2), 16) / 255f;
                    green = Convert.ToInt32(hexValue.Substring(2, 2), 16) / 255f;
                    blue = Convert.ToInt32(hexValue.Substring(4, 2), 16) / 255f;
                    return UIColor.FromRGBA(red, green, blue, alpha).NotNull();
                default:
                    return UIColor.Clear.NotNull();
            }
        }
    }
}